package flappyBird;

import java.awt.*;

public class Bird extends Rectangle {

    public final Color BIRD_COLOR = new Color(34, 35, 36);
    public final int BIRD_MAX_Y_SPEED = 15;
    private int ySpeed = 0;

    public Bird(int x, int y, int width, int height){
        super(x, y, width, height);
    }

    public void paintBird(Graphics g){
        g.setColor( BIRD_COLOR );
        g.fillRect(x, y, width, height);
    }

    public void jump(){
        if( this.ySpeed > 0 ){
            this.ySpeed = 0;
        }
        if( this.ySpeed > -13 ){
            this.ySpeed -= 10;
        }else{
            this.ySpeed = -13;
        }
    }

    public void setySpeed(int ySpeed) {
        this.ySpeed = ySpeed;
    }

    public int getySpeed() {
        return this.ySpeed;
    }

}
