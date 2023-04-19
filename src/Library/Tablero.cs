using System;

namespace obtenerTablero;

class Tablero{

    private bool [,] tablero (get; set;)

    public void nuevotablero(Tablero nuevotablero) {

        this.tablero= nuevotablero.tablero;
    }


    public int getHeight(){

        return this.tablero.getLength(1);
    }

    public int getWidth(){

        return this.tablero.getLength(0);

    }

    public bool getCell(int x, int y){

        return tablero[x,y]
    }

    public void setCell(int x, int y, bool alive){


        tablero[x,y]=alive;
    }




}
