using System;

public class AtmCard
{
    string firstname;
    string lastname;
    double balance;
    String cardnum;
    int pin;
    


    public AtmCard(
        string firstname, string lastname, double balance, int pin, string cardnum)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.balance = balance;
        this.pin = pin;
        this.cardnum = cardnum;

    }
    public string getfirstname()
    {
        return firstname;
    }
    public string getlastname()
    {
        return lastname;
    }
    public int getpin()
    {
        return pin;
    }
    public double getbalance()
    {
        return balance;
    }
     
    public string getcardnum()
    {
        return cardnum;
    }

    public void setfirstname(string newfirstname)
    {
        newfirstname = firstname;
    }

    public void setlastname(string newlastname)

    {
        newlastname = lastname;    
    }
    public void setpin(int newpin)
    {
        pin = newpin;
    }
    public void setbalance(double newbalance)
    {
        balance = newbalance;
    }
    public void setcardnum(string newcardnum)
    {
        cardnum = newcardnum;
    }

}