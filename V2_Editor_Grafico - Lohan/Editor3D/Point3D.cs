
public class Point3D {

    private float[,] valor = new float[1,4];

    public Point3D() {
        this.valor[0,0] = 0f;  //x
        this.valor[0,1] = 0f;  //y
        this.valor[0,2] = 0f;  //z
        this.valor[0,3] = 1f;  //w
    }
    
    public Point3D(float[,] valor) {
        this.valor = valor;
    }

    public Point3D(float x, float y, float z) {
        this.valor[0,0] = x;
        this.valor[0,1] = y;
        this.valor[0,2] = z;
        this.valor[0,3] = 1f;
    }

    public float getX() {
        return this.valor[0,0];
    }

    public void setX(float x) {
        this.valor[0,0] = x;
    }

    public float getY() {
        return this.valor[0,1];
    }

    public void setY(float y) {
        this.valor[0,1] = y;
    }
    
    public float getZ() {
        return this.valor[0,2];
    }

    public void setZ(float y) {
        this.valor[0,2] = y;
    }

    public float getW() {
        return this.valor[0,3];
    }

    public void setW(float w) {
        this.valor[0,3] = w;
    }

    public float[,] getValor() {
        return valor;
    }

    public void setValor(float[,] valor) {
        this.valor = valor;
    }

    
}
