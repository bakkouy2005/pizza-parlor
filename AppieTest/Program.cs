using System;

class Program
{
 static void Main()
 {
  var tijd = DateTime.Now.ToLocalTime();

  Console.WriteLine("------------WELKOM BIJ NEW YORK PIZZA------------");
  Console.WriteLine("------------datum " + tijd + " -----------");

  Console.WriteLine("Welke pizza soort wil je?");
  string pizza = Console.ReadLine();

  int magherita = 5;
  int peperoni = 9;
  int totaalkosten = 0;

  if (pizza == "peperoni")
  {
   Console.WriteLine("Hoeveel pizzas wil je?");
   int hoeveelheid = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Prima! We gaan voor je aan de slag, je pizza kost");
   totaalkosten = peperoni * hoeveelheid;
   Console.WriteLine(totaalkosten);
  }

  double PAYPAL = totaalkosten * 0.03;
  double IDEAL = totaalkosten * 0.01;
  double CREDITCARD = totaalkosten * 0.10;

  Console.WriteLine("Hoe wilt u gaan betalen?");
  Console.WriteLine("CREDITCARD, PAYPAL, IDEAL");

  string betaalmethode = Console.ReadLine();

  if (betaalmethode != "IDEAL" && betaalmethode != "PAYPAL" && betaalmethode != "CREDITCARD")
  {
   Console.WriteLine("Betaalmetode bestaat niet, probeer opnieuw");
  }
  else
  {
   double afrekenenPizza = 0;

   if (betaalmethode == "PAYPAL")
   {
    afrekenenPizza = totaalkosten + PAYPAL;
   }
   else if (betaalmethode == "CREDITCARD")
   {
    afrekenenPizza = totaalkosten + CREDITCARD;
   }
   else if (betaalmethode == "IDEAL")
   {
    afrekenenPizza = totaalkosten + IDEAL;
   }

   Console.WriteLine("------------TOTAAL :" + afrekenenPizza);
  }
 }
}







