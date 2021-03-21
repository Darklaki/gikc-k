package flappyBird;

import javax.swing.JFrame;
import javax.swing.Timer;
import java.awt.*;
import java.awt.event.*;
import java.util.ArrayList;
import java.util.Random;

public class FlappyBird implements ActionListener, MouseListener, KeyListener {

    public static FlappyBird flappyBird;
    public boolean gameOver = false;
    public boolean gameStarted = false;
    public final int FRAME_WIDTH = 1500, FRAME_HEIGHT = 800;
    public Random random;
    public Renderer renderer;
    public Bird bird;
    public ArrayList<Column> columns;
    public int tick;
    public int score = 0;

    public final int GRASS_HEIGHT = 125;

    public static void main(String[] args) {
        flappyBird = new FlappyBird();
    }

    public FlappyBird(){
        JFrame jframe = new JFrame();
        Timer timer = new Timer(17, this);

        renderer = new Renderer();
        random = new Random();

        //init jframe
        jframe.add(renderer);
        jframe.setSize(this.FRAME_WIDTH, this.FRAME_HEIGHT);
        jframe.setVisible(true);
        jframe.setResizable(false);
        jframe.setTitle("Flappy Bird");
        jframe.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        jframe.addMouseListener(this);
        jframe.addKeyListener(this);

        this.initGameObjects();

        timer.start();
    }

    public void initGameObjects(){
        //init bird
        bird = new Bird(this.FRAME_WIDTH / 2 - 10, this.FRAME_HEIGHT / 2 - 10, 20, 20);
        //init columns
        columns = new ArrayList<Column>();
        this.addColumn(true);
        this.addColumn(false);
        this.addColumn(false);
        this.addColumn(false);
    }
    
    public void addColumn(boolean firstColumns){
        int space = 300;
        int width = 100;
        int height = 50 + random.nextInt(300);

        int newColumnX = 0;
        if( firstColumns ){
            newColumnX = FRAME_WIDTH;
        }else{
            int lastColumnX = this.columns.get(this.columns.size() - 1).x;
            newColumnX = lastColumnX + 600;
        }

        // bottom column
        Column bottomColumn = new Column (
                newColumnX,
                FRAME_HEIGHT - height - this.GRASS_HEIGHT,
                width,
                height);
        // top column
        Column topColumn = new Column(
                newColumnX,
                0,
                width,
                FRAME_HEIGHT - height - space
        );

        columns.add(topColumn);
        columns.add(bottomColumn);

    }


    public void repaint(Graphics g) {

        //paint bg
        g.setColor(new Color(148, 198, 224));
        g.fillRect(0, 0, this.FRAME_WIDTH, this.FRAME_HEIGHT);

        //paint ground
        g.setColor(new Color(75, 168, 73));
        g.fillRect(0, this.FRAME_HEIGHT - this.GRASS_HEIGHT, this.FRAME_WIDTH, this.GRASS_HEIGHT);

        bird.paintBird(g);

        for (Column col : this.columns){
            col.paintColumn(g);
        }

        g.setColor(Color.white);
        g.setFont(new Font("Lato", 1,50));

        if( !this.gameStarted ){
            g.drawString("Kliknij aby zacząć!", this.FRAME_WIDTH / 2 - 210, this.FRAME_HEIGHT / 2);
        }

        if( this.gameOver ){
            g.drawString("Koniec gry!", this.FRAME_WIDTH / 2 - 130, this.FRAME_HEIGHT / 2);
        }

        if( !this.gameOver && this.gameStarted ){
            g.setFont(new Font("Lato", 1,20));
            g.drawString("Wynik: " + this.score, 10, 30);
        }

    }

    public void interaction(){
        if( this.gameOver ){
            //restart game
            this.gameOver = false;
            this.score = 0;
            this.initGameObjects();
        }

        if( !this.gameStarted ){
            //start game
            this.gameStarted = true;
        }

        if( this.gameStarted && !this.gameOver ){
            bird.jump();
        }
    }

    // on timer
    @Override
    public void actionPerformed(ActionEvent e) {
        this.tick++;
        int columnsSpeed = 10;

        if( gameStarted ){

            // move y bird
            if( bird.getySpeed() < bird.BIRD_MAX_Y_SPEED ){
                bird.setySpeed( bird.getySpeed() + 1 );
            }
            bird.y += bird.getySpeed();

            // move x columns
            for (Column col : this.columns){
                col.x -= columnsSpeed;
            }

            // generate new column
            Column lastColumn = this.columns.get(this.columns.size() - 1);
            if( lastColumn.x < this.FRAME_WIDTH ){
                //if last column is visible add new column
                this.addColumn(false);
            }

            // remove first column
            Column firstColumn = this.columns.get(0);
            if( firstColumn.x + firstColumn.width < 0 ){
                //if column not visible - remove;
                this.columns.remove(0);
                this.columns.remove(0);
            }


            for (Column col : this.columns){

                //add score
                if( col.y == 0 && (bird.x + bird.width) / 2 > (col.width + col.x) / 2 - 1 && (bird.x + bird.width) / 2 < (col.width + col.x) / 2 + 1 ) {
                    this.score++;
                }

                // collision
                if( col.intersects(bird) ){

                    this.gameOver = true;

                    if( bird.x <= col.x ){
                        //intersects sides of columns
                        bird.x = col.x - bird.width;
                    }else{
                        //intersects column gap
                        if( col.y != 0 ){
                            // bottom
                            bird.y = col.y - bird.width;
                        }else{
                            // top
                            bird.y = col.height;
                            bird.setySpeed(0);
                        }
                    }

                }
            }

            if( bird.y + bird.height > this.FRAME_HEIGHT - this.GRASS_HEIGHT ){
                bird.y = this.FRAME_HEIGHT - this.GRASS_HEIGHT - bird.height;
                this.gameOver = true;
            }

            if( bird.y < 0 ){
                bird.y = 0;
                this.gameOver = true;
            }

        }

        renderer.repaint();
    }

    @Override
    public void mouseClicked(MouseEvent e) {
        this.interaction();
    }

    @Override
    public void mousePressed(MouseEvent e) {

    }

    @Override
    public void mouseReleased(MouseEvent e) {

    }

    @Override
    public void mouseEntered(MouseEvent e) {

    }

    @Override
    public void mouseExited(MouseEvent e) {

    }

    @Override
    public void keyTyped(KeyEvent e) {

    }

    @Override
    public void keyPressed(KeyEvent e) {

    }

    @Override
    public void keyReleased(KeyEvent e) {
        if( e.getKeyCode() == KeyEvent.VK_SPACE ){
            this.interaction();
        }
    }
}
