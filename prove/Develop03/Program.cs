using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        // String of arrays that hold scriptures that can be pulled at randome 
        // this is my strech chalenge were is pulling a scripture at randome 
        String[] Scriptures = new string[3]
        {"Alma: 7 11-2; And he shall go forth, suffering pains and afflictions and temptations of every kind, and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.",
        "John: 3 16; For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have heverlasting life.",
        "Ether: 12 27; And if men come unto me I will show unto them their aweakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."};

        // getting a random number as the index 
        Random RandomValue = new Random();
        int randNum = RandomValue.Next(0, 3);

        // Here we are spliting the string to get the right parts so they can be inputed in to the class 
        // i split it in many parts to get them were they need to go. 
        string elemntInScripture = Scriptures[randNum];

        var item = elemntInScripture.Split(";");

        string referenceScripture = item[0];

        string verseScripture = item[1];

        var referenceItems = referenceScripture.Split(":");

        string referenceBook = referenceItems[0];

        string referenceChapter = referenceItems[1];

        var chapterNum = referenceChapter.Split(" ");

        string verseScriptures = chapterNum[1];
        
        var versNum = verseScriptures.Split("-");

        string verse1 = versNum[0];

        //Here we are using a if statemnt to get the scripture that have more than one verse. 
        // than calls the classes 
        //i got a class for getting teh word 
        // another class that read the referance
        // and another class that put the scripture togther

        if (versNum.Count() == 1)
        {
            Verses verse = new Verses(elemntInScripture);
            verse.showWord();
            ScriptureReference reference = new ScriptureReference(referenceBook,referenceChapter, verse1 );
            Scripture scripture = new Scripture( reference.DisplayReferance(), verseScripture);
            scripture.AddWord();
            scripture.Printword();
        }

        else if (versNum.Count() == 2)
        {
            string verse2 = versNum[1];
            Verses verse = new Verses(elemntInScripture);
            verse.showWord();
            ScriptureReference reference = new ScriptureReference(referenceBook,referenceChapter, verse1, verse2 );
            Scripture scripture = new Scripture( reference.DisplayReferance(), verseScripture);
            scripture.AddWord();
            scripture.Printword();
        }


     

        
           
    
    
    
    
    

        

    }
}