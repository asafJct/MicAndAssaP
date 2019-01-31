using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public interface IBL
    {
        int calculate_age(DateTime t);//gets an birthday
                                      //return the age of the person.
        #region Tester

        bool findTester(int tt);//gets a key id address
                                //return if he exists.
        void addTester(Tester t);//gets a new object from type tester
                                 //then add this tester to the data source.
        void deleteTester(Tester t);//gets an exist object from type tester
                                    //then delete it.
        void updateTester(Tester t);//update an exist data.
                                    
        IEnumerable<Tester> getAllTester(Func<Tester, bool> predicat = null);//gets predicate , this function uses the Data source
                                                                             //recive all appropriate testers  
        List<Tester> InRange(string _address);//gets an address
                                              //then return all Tester in the range
                                              //it is done by comparition to the Tester key maximum range.

        #endregion

        #region Trainee
        bool findTrainee(Trainee dd);
        void addTrainee(Trainee od);  
        void deleteTrainee(BE.Tester o);   //
        void updateTrainee(BE.Tester o);  //עדכון הזמנה
        IEnumerable<Trainee> getAllTrainee(Func<Tester, bool> predicat = null);//נבחנים
        int numberOfTest(Trainee t);
        bool  eligible(Trainee t);
        #endregion
        #region Test

        bool findTest(Test dd);
        void addTest(Test y);
        void deleteTest(Test od);  //מחיקת מנה_מוזמנת
        IEnumerable<Test> getAllTest(Func<Tester, bool> predicat = null);//מבחנים
        #endregion
        
    }
}

