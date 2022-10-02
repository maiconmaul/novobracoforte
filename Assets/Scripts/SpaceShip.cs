using System.Collections;
using System.Collections.Generic;

public class SpaceShip
{
    //default res = 4, pisci = 4;
    private int pisciological, resistence, resistenceMax, RadiationRes, metabolism,dnaCount;



    public SpaceShip(int pisciological, int resistence){
        this.pisciological = pisciological;
        this.resistence = resistence;
        this.dnaCount = 0;
    }

    public void addDna(int dna)
    {
        this.dnaCount += dna;
    }

    public int DnaCount { get => dnaCount; }

    public void addPisciological(int pisci){
        this.pisciological += pisci;
    }
    public void addResistence(int res){
        this.resistence += res;
    }

    public int getPisciological(){
        return this.pisciological;
    }

    public int getResistence(){
        return this.resistence;
    }

    public void removeLife(int life)
    {
        this.resistence -= life;
    }

}
