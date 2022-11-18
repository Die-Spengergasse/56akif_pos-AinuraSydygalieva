using Spg.PluePos._01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{   
    public class SmartPhoneApp : List<Post>  
    {
        public string SmartPhoneId { get; set; } = string.Empty;

        /*   Diese Klasse soll selbst zu einer Liste werden.
         *   Leite daher von der Klasse List ab. Achtung,
           typisiere die Klasse List<>, auf den richtigen Datentyp!*/
        

        //Erstelle einen Konstruktor, der den Parameter SmartPhoneId entgegennimmt.
        public SmartPhoneApp(string smartPhoneId)
        {
            SmartPhoneId = smartPhoneId;
        }

        //METHODS:

        /*Überschreibe die Add-Methode. Verwende dafür in der Methodensignatur das Keyword 
        „new“ (public void new Add(…)). Sie soll nur Post in die Liste aufnehmen können, wenn der 
        Post nicht NULL ist. Es soll auch eine Referenz von SmartPhoneApp auf die Klasse Post gesetzt 
        werden.
             
        /*public new void Add(SmartPhoneApp item)
        {
            if( (item != null))
            {
                Add(item);
        }*/
        public new void Add(Post item)
        {
            if (item is null)
            {
                throw new ArgumentNullException("Post war NULL!");
            }

            else if (!base.Contains(item))
            {
                base.Add(item);
                //item.SmartPhoneNavigation(this);
            }
            else
            {
                throw new ArgumentException("SmartPhoneApp enthält bereits den Post !");
            }
        }
        /*Erstelle eine Methode ProcessPosts. Sie durchläuft alle Posts in der Liste und fügt alle HTMLAusgaben
         * der einzelnen Posts zu einem kompletten String zusammen (mittels simplem 
           Concatenate) Der resultierende String soll anschließend zurückgegeben werden. (return…)*/
        public string ProcessPosts()
        { 
            string kompletterString = string.Empty;

            foreach (Post post in this) 
            {
                kompletterString += post.Html;
            }

            return kompletterString;
        }

            /*Erstelle eine Methode CalcRating. Sie durchläuft alle Posts in der Liste und summiert alle 
            Ratings der einzelnen Posts auf. Das Ergebnis soll anschließend zurückgegeben werden.*/
        public int CalcRating()
        {
            int ergebnis = 0;

            foreach (Post item in this)
            {
                ergebnis += item.Rating;
            }

            return ergebnis;
        }
            /*
             Erstelle einen Indexer, der anhand des Title einen Post zurückliefern kann. Der Aufruf würde 
            folgendermaßen aussehen: “posts["TextPost 6"]?.Html“. Kann der Post nicht in der 
            Liste gefunden werden, soll null zurückgegeben werden.*/

        /*public Post this[Post "TextPost 6"]
        {
            get
            {
                if (!posts.Contains("TextPost 6"))
                {
                    return null;
                }
                else
                {
                    return posts["TextPost 6"]?.Html;
                }
            }
        }*/

    }
}
