package flappyBird;

import java.awt.*;

public class Column extends Rectangle {

    public final Color COLUMN_COLOR = new Color(205, 168, 130);

    public Column(int x, int y, int width, int height){
        super(x, y, width, height);
    }

    public void paintColumn(Graphics g){
        g.setColor( COLUMN_COLOR );
        g.fillRect(x, y, width, height);
    }

}
