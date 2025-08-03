using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class CustomerController: MonoBehaviour
{
    [SerializeField]
    private RngMachine rngmachine;
    private int[] roll;
    public List<string> masterlist;
    public static string[] beans = {
        "add in arabica beans ", "add in robusta beans ", "add in liberica beans ", "add in excelsa beans ", "add in typica beans ", "add in geisha beans ", "add in bourbon beans "
    };

    public static string[] coffee_base = {
        "add an espresso", "add a ristretto",  "add a doppio", "make it a red eye", "add an americano", "add a latte",
        "add a cappuccino", "make it a flat white", "make it a café au lait", "add a cortado", "add a macchiato", "add a mocha",
        "black eye", "café bonbon", "brev", "cortadito", "espresso con pana",
        "add an espressino", "make it a frappe", "make it a galao", "make it a yirgacheffe","make it a Türk Kahvesi"
    };

    public static string[] roast = {
        "light roast it", "medium roast it", "dark roast it", "blonde roast it", "city roast it", "full_city roast it",
        "vienna roast it", "french roast it", "italian roast it", 
    };

    public static string[] brewing = {
        "drip brew it", "use pour over", "espresso brew it", "use cold brew ", "cafetiere brew it"
    };

    public static string[] syrups = {
        "add vanilla syrup", "add chocolate syrup", "add caramel syrup", "add strawberry syrup", "add cookie syrup", "add crumble syrup",
        "add mocha syrup", "add hazelnut syrup", "add lavender syrup", "add salted_caramel syrup", "add matcha syrup", "add cinnamon syrup",
        "add toffee syrup", "add mint syrup", "add raspberry syrup", "add gingerbread syrup", "add coconut syrup", "add buttered pecan syrup",
        "add pumpkin_spice syrup", "add orange syrup", "add pistachio syrup", "add honey", "add cardamom syrup", "add white chocolate syrup",
        "add mango syrup", "add blueberry syrup", "add peach syrup", "add passion fruit syrup"
    };

    public static string[] alternatives = {
        "add some ice", "add horchata", "add lemonade", "add dolce", "add tea", "add iced tea", "add hibiscus tea",
        "add lemon tea", "add matcha", "add chai", "add agua de agua", "add green tea", "add sakura tea"
    };
    public static string[] milks = {"use cold milk", "use steamed milk", "use vanilla creme", "use skimmed milk", "use almond milk",
        "use oat milk",  "use a non dairy creamer", "use soy milk", "use coconut milk", "put foam on it",};

    public static string[] chaos = {
        "use plutonium", "add some battery_acid to it", "sprinkle some iron oxide", "add a cat's hairball", "serve it with 20 cocktail umbrellas",
        "add a swirly straws", "chuck an entire papaya in it", "mix in some shampoo", "squirt some squid_ink in it", "add some lumpy protein_powder", "add 2 kilos of creatine","add 5 litres of gasoline"
    };
    public static string[] levels = { "make it caffeinated ", " make it decaffeinated " };


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("CustomerController Start");
    }
    private void Awake()
    {
        roll = new int[25];
        roll = rngmachine.generateseed();
        masterlist = customerlist();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public List<string> customerlist()
    {
        List<string> custlist = new List<string>();

        if (roll == null || roll.Length == 0)
        {
            Debug.LogWarning("Roll not Initialized");
            roll = rngmachine.generateseed();
        }

        // First 3: Fixed category picks
        int rnd0 = Random.Range(0, beans.Length);
        custlist.Add(beans[rnd0]);

        int rnd1 = Random.Range(0, coffee_base.Length);
        custlist.Add(coffee_base[rnd1]);

        int rnd2 = Random.Range(0, roast.Length);
        custlist.Add(roast[rnd2]);

        // Now continue normal generation starting from index 3
        for (int j = 3; j < roll.Length; j++)
        {
            int i = roll[j]; // The actual roll value

            if (i >= 0 && i <= 10)
            {
                int rnd = Random.Range(0, beans.Length);
                custlist.Add(beans[rnd]);
            }
            else if (i >= 11 && i <= 25)
            {
                int rnd = Random.Range(0, coffee_base.Length);
                custlist.Add(coffee_base[rnd]);
            }
            else if (i >= 26 && i <= 30)
            {
                int rnd = Random.Range(0, roast.Length);
                custlist.Add(roast[rnd]);
            }
            else if (i >= 31 && i <= 40)
            {
                int rnd = Random.Range(0, brewing.Length);
                custlist.Add(brewing[rnd]);
            }
            else if (i >= 41 && i <= 70)
            {
                int rnd = Random.Range(0, syrups.Length);
                custlist.Add(syrups[rnd]);
            }
            else if (i >= 71 && i <= 85)
            {
                int rnd = Random.Range(0, alternatives.Length);
                custlist.Add(alternatives[rnd]);
            }
            else if (i >= 86 && i <= 95)
            {
                int rnd = Random.Range(0, chaos.Length);
                custlist.Add(chaos[rnd]);
            }
            else if (i >= 96 && i <= 98)
            {
                int rnd = Random.Range(0, milks.Length);
                custlist.Add(milks[rnd]);
            }
            else
            {
                int rnd = Random.Range(0, levels.Length);
                custlist.Add(levels[rnd]);
            }
        }

        return custlist;
    }
    public List<string> getmasterlist()
    {
        return masterlist;
    }
    
}
