import javax.imageio.ImageIO;
import javax.swing.*;
import javax.swing.border.Border;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

import static java.lang.Double.parseDouble;
import static java.lang.Integer.parseInt;

public class Window extends JFrame {
    private int WINDOW_HEIGHT = 850, WINDOW_WIDTH = 1100;
    JFrame thisPointer;

    public Window() {
        super("Edytor zdjęć");
        thisPointer = this;
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(WINDOW_WIDTH, WINDOW_HEIGHT);
    }

    public ActionListener drawOnImage(CustomImage imageContainer){
        return new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                JFileChooser fileChooser = new JFileChooser();

                int res = fileChooser.showOpenDialog(thisPointer);
                if(res == JFileChooser.APPROVE_OPTION){
                    File file = fileChooser.getSelectedFile();
                    try {
                        BufferedImage b = ImageIO.read(file);
                        imageContainer.setImage( b );
                    }catch (IOException exception){
                        System.out.println(exception.getMessage());
                    }
                }

                fileChooser.approveSelection();
                fileChooser.updateUI();

            }
        };
    }

    public void paint(Graphics g){
        super.paint(g);

        Config conf =  new Config();

        JPanel wrapperPanel = new JPanel();
        wrapperPanel.setLayout( new BorderLayout() );
        getContentPane().add(wrapperPanel);

        JPanel configPanel = new JPanel();
        configPanel.setBackground(new Color(231, 227, 226));
        configPanel.setLayout( new BoxLayout(configPanel, BoxLayout.Y_AXIS) );
        wrapperPanel.add(configPanel, BorderLayout.WEST);


        JPanel resultPanel = new JPanel();
        resultPanel.setBackground(new Color(213, 211, 211));
        resultPanel.setLayout( null );
        //resultPanel.setBounds(0,0,200,200);
        wrapperPanel.add(resultPanel, BorderLayout.CENTER);

        /* LOAD IMAGES */

        // image 1
        CustomImage image1 = new CustomImage(0, 0, 200, 200);
        image1.setBackground(new Color(100,100,100));
        resultPanel.add(image1);

        // image 2
        CustomImage image2 = new CustomImage(200, 0, 200, 200);
        image2.setBackground(new Color(100,100,100));
        resultPanel.add(image2);

        JButton addImg1 = new JButton("Zdjęcie 1");
        configPanel.add( addImg1 );
        addImg1.addActionListener(this.drawOnImage(image1));

        JButton addImg2 = new JButton("Zdjęcie 2");
        configPanel.add( addImg2 );
        addImg2.addActionListener(this.drawOnImage(image2));

        // result image
        CustomImage imageResult = new CustomImage(1, 200, 200, 200);
        resultPanel.add(imageResult);

        /* LINEAR TRANSFORMATION */
        JTextField linkTransfA = new JTextField(1);
        linkTransfA.setMaximumSize(new Dimension(200, 20));
        linkTransfA.setText("1");
        configPanel.add(linkTransfA);

        JTextField linkTransfB = new JTextField(1);
        linkTransfB.setText("1");
        linkTransfB.setMaximumSize(new Dimension(200, 20));
        configPanel.add(linkTransfB);

        JButton linearTransformatioSubmit = new JButton("Transf. liniowa");
        configPanel.add( linearTransformatioSubmit );
        linearTransformatioSubmit.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setLinear_a(
                            parseInt( linkTransfA.getText() )
                    );
                    conf.setLinear_b(
                            parseInt( linkTransfB.getText() )
                    );
                    conf.setLinear_transformation(true);
                    conf.setPower_transformation(false);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* POWER TRANSFORMATION */
        JTextField linkPowerA = new JTextField(1);
        linkPowerA.setMaximumSize(new Dimension(200, 20));
        linkPowerA.setText("1");
        configPanel.add(linkPowerA);

        JTextField linkPowerB = new JTextField(1);
        linkPowerB.setText("1");
        linkPowerB.setMaximumSize(new Dimension(200, 20));
        configPanel.add(linkPowerB);

        JButton powerTransformationSubmit = new JButton("Transf. potęgowa");
        configPanel.add( powerTransformationSubmit );
        powerTransformationSubmit.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setPower_c(
                            parseInt( linkPowerA.getText() )
                    );
                    conf.setPower_n(
                            parseInt( linkPowerB.getText() )
                    );
                    conf.setPower_transformation(true);
                    conf.setLinear_transformation(false);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /**
         *
         * Mix modes
         * */

        /* Additive mode */
        JButton mixAddBtn = new JButton("Suma");
        configPanel.add( mixAddBtn );
        mixAddBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_additive(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Subtractive mode */
        JButton mixSubBtn = new JButton("Odejmowanie");
        configPanel.add( mixSubBtn );
        mixSubBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_subtractive(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Difference mode */
        JButton mixDiffButton = new JButton("Różnica");
        configPanel.add( mixDiffButton );
        mixDiffButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_diff(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Multiply mode */
        JButton mixMultiButton = new JButton("Mnożenie");
        configPanel.add( mixMultiButton );
        mixMultiButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_multiply(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Screen mode */
        JButton mixScreeenButton = new JButton("Mnożenie odwrotności");
        configPanel.add( mixScreeenButton );
        mixScreeenButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_screen(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Negation mode */
        JButton mixNegationButton = new JButton("Negacja");
        configPanel.add( mixNegationButton );
        mixNegationButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_negation(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Darken mode */
        JButton mixDarkenButton = new JButton("Ciemniejsze");
        configPanel.add( mixDarkenButton );
        mixDarkenButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_darken(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /*  Lighten mode */
        JButton mixLightenButton = new JButton("Jaśniejsze");
        configPanel.add( mixLightenButton );
        mixLightenButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_lighten(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Exclusion mode */
        JButton mixExclusionButton = new JButton("Wyłączenie");
        configPanel.add( mixExclusionButton );
        mixExclusionButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_exluclusion(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Overlay mode */
        JButton mixOverlayButton = new JButton("Nakładka");
        configPanel.add( mixOverlayButton );
        mixOverlayButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_overlay(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /*  Hard light mode */
        JButton mixHardLightButton = new JButton("Ostre światło");
        configPanel.add( mixHardLightButton );
        mixHardLightButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_hardLight(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Soft light mode */
        JButton mixSoftLightButton = new JButton("Łagodne światło");
        configPanel.add( mixSoftLightButton );
        mixSoftLightButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_softLight(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Color dodge mode */
        JButton mixDodgeButton = new JButton("Rozcieńczenie");
        configPanel.add( mixDodgeButton );
        mixDodgeButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_colorDodge(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Color burn mode */
        JButton mixBurnButton = new JButton("Wypalanie");
        configPanel.add( mixBurnButton );
        mixBurnButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_colorBurn(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Reflect mode */
        JButton mixReflectButton = new JButton("Reflect mode");
        configPanel.add( mixReflectButton );
        mixReflectButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_reflect(true);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* Transparency, Opacity */
        JTextField transAlpha = new JTextField(1);
        transAlpha.setMaximumSize(new Dimension(200, 20));
        transAlpha.setText("1.0");
        configPanel.add(transAlpha);

        JButton mixOpacityButton = new JButton("Przezroczystość");
        configPanel.add( mixOpacityButton );
        mixOpacityButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setMix_transparency(true);
                    conf.setTransparency_alpha(
                            parseDouble( transAlpha.getText() )
                    );
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });

        /* RESET BUTTON (default, no filters) */
        JButton resetConfig = new JButton("Reset");
        configPanel.add( resetConfig );
        resetConfig.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    conf.setLinear_a(1);
                    conf.setLinear_b(1);
                    conf.setLinear_transformation(false);
                    conf.setPower_c(1);
                    conf.setPower_n(1);
                    conf.setPower_transformation(false);
                    conf.setMix_additive(false);
                    conf.setMix_subtractive(false);
                    conf.setMix_diff(false);
                    conf.setMix_multiply(false);
                    conf.setMix_screen(false);
                    conf.setMix_negation(false);
                    conf.setMix_darken(false);
                    conf.setMix_lighten(false);
                    conf.setMix_exluclusion(false);
                    conf.setMix_overlay(false);
                    conf.setMix_hardLight(false);
                    conf.setMix_softLight(false);
                    conf.setMix_colorDodge(false);
                    conf.setMix_colorBurn(false);
                    conf.setMix_reflect(false);
                    conf.setMix_transparency(false);
                    generateResult( image1, image2, imageResult, conf );
                }catch (Exception exc){
                    System.out.println(exc.getMessage());
                }

            }
        });


    }

    public void generateResult(CustomImage img1, CustomImage img2, CustomImage imgRes, Config conf){

        BufferedImage img1_buff = img1.getImageBuffer();
        BufferedImage img2_buff = img2.getImageBuffer();
        // get width
        int w = img1_buff.getWidth() <= img2_buff.getWidth() ? img1_buff.getWidth() : img2_buff.getWidth();
        // get height
        int h = img1_buff.getHeight() <= img2_buff.getHeight() ? img1_buff.getHeight() : img2_buff.getHeight();

        BufferedImage new_image = new BufferedImage(w, h, BufferedImage.TYPE_INT_ARGB);

        for ( int i = 0; i < h; i++ ){
            for ( int j = 0; j < w; j++ ){

                int red_1, green_1, blue_1;
                if( i <= img1_buff.getHeight() && j <= img1_buff.getWidth() ){
                    Color c1 = new Color( img1_buff.getRGB(j,i) );
                    red_1 = (int)(c1.getRed());
                    green_1 = (int)(c1.getGreen());
                    blue_1 = (int)(c1.getBlue());
                }else{
                    red_1 = 0;
                    green_1 = 0;
                    blue_1 = 0;
                }
                int red_2, green_2, blue_2;
                if( i <= img2_buff.getHeight() && j <= img2_buff.getWidth() ){
                    Color c2 = new Color( img2_buff.getRGB(j,i) );
                    red_2 = (int)(c2.getRed());
                    green_2 = (int)(c2.getGreen());
                    blue_2 = (int)(c2.getBlue());
                }else{
                    red_2 = 0;
                    green_2 = 0;
                    blue_2 = 0;
                }

                int x = 0, y = 0, z = 0;

                /* LINEAR TRANSFORMATION */
                if( conf.linear_transformation ){

                    int a = conf.linear_a;
                    int b = conf.linear_b;

                    x = a * red_1 + b;
                    y = a * green_1 + b;
                    z = a * blue_1 + b;

                }

                /* POWER TRANSFORMATION */
                if( conf.power_transformation ){

                    int c = conf.power_c;
                    int n = conf.power_n;

                    //
                    x = (int)Math.pow(c * red_1, n);
                    y = (int)Math.pow(c * green_1, n);
                    z = (int)Math.pow(c * blue_1, n);

                }

                /**
                 *
                 * Mix modes
                 * */

                if(conf.mix_additive){
                    x = red_1 + red_2;
                    y = green_1 + green_2;
                    z = blue_1 + blue_2;
                }

                if( conf.mix_subtractive ){
                    x = red_1 + red_2 - 1;
                    y = green_1 + green_2 - 1;
                    z = blue_1 + blue_2 - 1;
                }

                if( conf.mix_diff ){
                    x = Math.abs(red_1 - red_2);
                    y = Math.abs(green_1 - green_2);
                    z = Math.abs(blue_1 - blue_2);
                }

                if(conf.mix_multiply){
                    x = red_1 * red_2;
                    y = green_1 * green_2;
                    z = blue_1 * blue_2;
                }

                if(conf.mix_screen){
                    x = 1-(1-red_1) * (1-red_2);
                    y = 1-(1-green_1) * (1-green_2);
                    z = 1-(1-blue_1) * (1-blue_2);
                }

                if(conf.mix_negation){
                    x = 1-Math.abs(1-red_1-red_2);
                    y = 1-Math.abs(1-green_1-green_2);
                    z = 1-Math.abs(1-blue_1-blue_2);
                }

                if(conf.mix_darken){
                    x = red_1 < red_2 ? red_1 : red_2;
                    y = green_1 < green_2 ? green_1 : green_2;
                    z = blue_1 < blue_2 ? blue_1 : blue_2;
                }

                if(conf.mix_lighten){
                    x = red_1 > red_2 ? red_1 : red_2;
                    y = green_1 > green_2 ? green_1 : green_2;
                    z = blue_1 > blue_2 ? blue_1 : blue_2;
                }

                if(conf.mix_exluclusion){
                    x = red_1 + red_2 - 2 * red_1 * red_2;
                    y = green_1 + green_2 - 2 * green_1 * green_2;
                    z = blue_1 + blue_2 - 2 * blue_1 * blue_2;
                }

                if(conf.mix_overlay){
                    x =  red_1 < 0.5 ? 2*red_1*red_2 : 1 - 2*(1-red_1)*(1-red_2);
                    y =  green_1 < 0.5 ? 2*green_1*green_2 : 1 - 2*(1-green_1)*(1-green_2);
                    z =  blue_1 < 0.5 ? 2*blue_1*blue_2 : 1 - 2*(1-blue_1)*(1-blue_2);
                }

                if(conf.mix_hardLight){
                    x =  red_2 < 0.5 ? 2*red_1*red_2 : 1 - 2*(1-red_1)*(1-red_2);
                    y =  green_2 < 0.5 ? 2*green_1*green_2 : 1 - 2*(1-green_1)*(1-green_2);
                    z =  blue_2 < 0.5 ? 2*blue_1*blue_2 : 1 - 2*(1-blue_1)*(1-blue_2);
                }

                if(conf.mix_softLight){
                    x = (int)(red_2 < 0.5 ? ( 2*red_1*red_2 + Math.pow(red_1, 2) * (1 - 2*red_2)) : (Math.sqrt(red_1)*(2*red_2-1) + (2*red_1)*(1-red_2)));
                    y = (int)(green_2 < 0.5 ? ( 2*green_1*green_2 + Math.pow(green_1, 2) * (1 - 2*green_2)) : (Math.sqrt(green_1)*(2*green_2-1) + (2*green_1)*(1-green_2)));
                    z = (int)(blue_2 < 0.5 ? ( 2*blue_1*blue_2 + Math.pow(blue_1, 2) * (1 - 2*blue_2)) : (Math.sqrt(blue_1)*(2*blue_2-1) + (2*blue_1)*(1-blue_2)));
                }

                if(conf.mix_colorDodge){
                    if(1-red_2 != 0){
                        x = red_1/(1-red_2);
                    }
                    if(1-green_2 != 0){
                        y = green_1/(1-green_2);
                    }
                    if(1-blue_2 != 0){
                        z = blue_1/(1-blue_2);
                    }
                }

                if(conf.mix_colorBurn){
                    if(red_2 != 0){
                        x = 1-(1-red_1)/red_2;
                    }
                    if(green_2 != 0){
                        y = 1-(1-green_1)/green_2;
                    }
                    if(blue_2 != 0){
                        z = 1-(1-blue_1)/blue_2;
                    }
                }

                if(conf.mix_reflect){
                    if(1-red_2 != 0){
                        x = (int)Math.pow(red_1, 2/(1-red_2));
                    }
                    if(1-green_2 != 0){
                        y = (int)Math.pow(green_1, 2/(1-green_2));
                    }
                    if(1-blue_2 != 0){
                        z = (int)Math.pow(blue_1, 2/(1-blue_2));
                    }
                }

                if(conf.mix_transparency){
                    double alpha = conf.transparency_alpha;
                    x = (int)((1-alpha)*(red_2 + alpha)*red_1);
                    y = (int)((1-alpha)*(green_2 + alpha)*green_1);
                    z = (int)((1-alpha)*(blue_2 + alpha)*blue_1);
                }

                if (red_1 + x >=0 && red_1 + x <= 255){
                    red_1 = red_1 + x;
                }else{
                    red_1 = red_1;
                }

                if (green_1 + y >= 0 && green_1 + y <=255){
                    green_1 = green_1 + y;
                }else{
                     green_1 = green_1;
                }

                if (blue_1 + z >= 0 && blue_1 + z <=255){
                    blue_1 = blue_1 + z;
                }else{
                    blue_1 = blue_1;
                }

                Color newColor = new Color(red_1, green_1, blue_1);
                new_image.setRGB(j,i,newColor.getRGB());

            }
        }

        // show result
        imgRes.setImage(new_image);
    }

}


