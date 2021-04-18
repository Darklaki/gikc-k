import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;

public class CustomImage extends JPanel {

    private BufferedImage imageBuffer;
    private int top_c, left_c, width_c, height_c;

    public CustomImage(int top, int left, int width, int height){
        this.top_c = top;
        this.left_c = left;
        this.width_c = width;
        this.height_c = height;
        this.setBounds(left,top, width, height);
    }

    @Override
    public void paint(Graphics g){
        super.paintComponent(g);
        if( this.imageBuffer != null ){
//            g.drawImage(
//                    this.imageBuffer, this.left_c, this.top_c, this.width_c, this.height_c, null
//            );
            g.drawImage(
                    this.imageBuffer, 0, 0, this.width_c, this.height_c, this
            );
        }
    }

    public void setImage(BufferedImage imageBuffer){
        this.imageBuffer = imageBuffer;
        //this.paint(this.getGraphics());
        repaint();
    }

    public BufferedImage getImageBuffer(){
        return this.imageBuffer;
    }

}
