using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
        /*
         string Title (Default Property, Read Only)
        o DateTime Created (Default Property, Read Only)
         o int Rating (Es darf nur ein Wert zwischen 1 und 5 gesetzt werden. Andernfalls soll 
        eine ArgumentOutOfRangeException mit der Meldung “Range muss zwischen 1 und 5 
        liegen!" geworfen werden.)

        o abstract string Html (Default Property, abstract, Read Only)
        o SmartPhoneApp SmartPhone (Default Property, Es soll eine Referenz auf die Liste
        beinhalten) Achtung! Nullable-Feature: Wähle die richtige initialisierung.*/
        
    public abstract class Post
         {
            public string Title { get; } = string.Empty;
            
            public int Rating;
        public DateTime Created { get; }

        public int MyProperty
              {
                  get { return Rating; }
                    set
                    {
                      if (value >= 1 && value <= 5)
                      {
                         Rating = value;
                      }
                      else
                      {
                         throw new ArgumentOutOfRangeException("Range muss zwischen 1 und 5 liegen!");
                      }
             }
        }

        public SmartPhoneApp SmartPhone { get; set; } = default!;



        public virtual string Html { get; } = string.Empty;
             

             public Post(string _title, string _html)
            {
                Title = _title;
                Html = _html;
            }

            public Post()
            {
                Title = string.Empty;
                Html = string.Empty;
            }

            public Post(string title)
            {
                Title = title;
            }
            
             
            /*Erstelle einen Konstruktor der den Parameter „title“ entgegennimmt und den vorherigen 
             Konstruktor aufruft, um die Werte zu setzen. Für den Parameter „created“, verwende 
            DateTime.Now. */


    }

}

