using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Lists
    {
        //! LISTS
        
        private readonly List<Cards> _listRepo = new List<Cards>();

//! Add Card
         public bool AddCardToList(Cards card)
         {
             /*  
               - Add(T)
               - Adds our object to the end of the List.
             */ 
             if (card != null){
                _listRepo.Add(card);
                return true; // our return type is boolean.
             }
             return false;
         }

//! Get All
         public List<Cards> GetAllCards()
         {
                return _listRepo;
         }

//! Delete One
         public bool DeleteCard(int id)
        {
           /*
           FirstOrDefault() & Remove()
           -FirstOrDefault(): Iterate throught the List<T> and target the first item that matches the input
           provided (ID).

           - If there is none, providea default responde "No element found".
           - using a local variable (var) to handled any cases where null is returned.
           - Remove(): returns back a boolean value
           */

           System.Console.WriteLine(id);
           Cards cardToDelete = _listRepo.FirstOrDefault(c => c.ID == id);
           return _listRepo.Remove(cardToDelete);
         }

//! Delete All
         public bool ClearHand()
         {
             /*
                - Clear()
                - An action method that will remove all objects currently in the list.
             */
             if(_listRepo.Count > 0)
                {
                _listRepo.Clear();
                return true;
                }
                  return false;
         }
}
