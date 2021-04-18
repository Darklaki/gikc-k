public class Config {

    public int getLinear_a() {
        return linear_a;
    }

    public void setLinear_a(int linear_a) {
        this.linear_a = linear_a;
    }

    public int getLinear_b() {
        return linear_b;
    }

    public void setLinear_b(int linear_b) {
        this.linear_b = linear_b;
    }

    public boolean isLinear_transformation() {
        return linear_transformation;
    }

    public void setLinear_transformation(boolean linear_transformation) {
        this.linear_transformation = linear_transformation;
    }

    public int getPower_c() {
        return power_c;
    }

    public void setPower_c(int power_c) {
        this.power_c = power_c;
    }

    public int getPower_n() {
        return power_n;
    }

    public void setPower_n(int power_n) {
        this.power_n = power_n;
    }

    public boolean isPower_transformation() {
        return power_transformation;
    }

    public void setPower_transformation(boolean power_transformation) {
        this.power_transformation = power_transformation;
    }

    public boolean isMix_additive() {
        return mix_additive;
    }

    public void setMix_additive(boolean mix_additive) {
        this.mix_additive = mix_additive;
    }

    public boolean isMix_subtractive() {
        return mix_subtractive;
    }

    public void setMix_subtractive(boolean mix_subtractive) {
        this.mix_subtractive = mix_subtractive;
    }

    public boolean isMix_diff() {
        return mix_diff;
    }

    public void setMix_diff(boolean mix_diff) {
        this.mix_diff = mix_diff;
    }

    public boolean isMix_multiply() {
        return mix_multiply;
    }

    public void setMix_multiply(boolean mix_multiply) {
        this.mix_multiply = mix_multiply;
    }

    public boolean isMix_screen() {
        return mix_screen;
    }

    public void setMix_screen(boolean mix_screen) {
        this.mix_screen = mix_screen;
    }

    public boolean isMix_negation() {
        return mix_negation;
    }

    public void setMix_negation(boolean mix_negation) {
        this.mix_negation = mix_negation;
    }

    public boolean isMix_darken() {
        return mix_darken;
    }

    public void setMix_darken(boolean mix_darken) {
        this.mix_darken = mix_darken;
    }

    public boolean isMix_lighten() {
        return mix_lighten;
    }

    public void setMix_lighten(boolean mix_lighten) {
        this.mix_lighten = mix_lighten;
    }

    public boolean isMix_exluclusion() {
        return mix_exluclusion;
    }

    public void setMix_exluclusion(boolean mix_exluclusion) {
        this.mix_exluclusion = mix_exluclusion;
    }

    public boolean isMix_overlay() {
        return mix_overlay;
    }

    public void setMix_overlay(boolean mix_overlay) {
        this.mix_overlay = mix_overlay;
    }

    public boolean isMix_hardLight() {
        return mix_hardLight;
    }

    public void setMix_hardLight(boolean mix_hardLight) {
        this.mix_hardLight = mix_hardLight;
    }

    public boolean isMix_softLight() {
        return mix_softLight;
    }

    public void setMix_softLight(boolean mix_softLight) {
        this.mix_softLight = mix_softLight;
    }

    public boolean isMix_colorDodge() {
        return mix_colorDodge;
    }

    public void setMix_colorDodge(boolean mix_colorDodge) {
        this.mix_colorDodge = mix_colorDodge;
    }

    public boolean isMix_colorBurn() {
        return mix_colorBurn;
    }

    public void setMix_colorBurn(boolean mix_colorBurn) {
        this.mix_colorBurn = mix_colorBurn;
    }

    public boolean isMix_reflect() {
        return mix_reflect;
    }

    public void setMix_reflect(boolean mix_reflect) {
        this.mix_reflect = mix_reflect;
    }

    public boolean isMix_transparency() {
        return mix_transparency;
    }

    public void setMix_transparency(boolean mix_transparency) {
        this.mix_transparency = mix_transparency;
    }

    public double getTransparency_alpha() {
        return transparency_alpha;
    }

    public void setTransparency_alpha(double transparency_alpha) {
        this.transparency_alpha = transparency_alpha;
    }

    int linear_a = 1;
    int linear_b = 1;
    boolean linear_transformation = false;
    int power_c = 1;
    int power_n = 1;
    boolean power_transformation = false;
    boolean mix_additive, mix_subtractive, mix_diff, mix_multiply, mix_screen, mix_negation, mix_darken, mix_lighten, mix_exluclusion, mix_overlay, mix_hardLight, mix_softLight, mix_colorDodge, mix_colorBurn, mix_reflect, mix_transparency = false;
    double transparency_alpha = 0;



}
