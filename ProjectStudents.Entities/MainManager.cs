using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectStudents.Model;

namespace ProjectStudents.Entities
{
    public class MainManager
    {
        private MainManager() { }

        private static readonly MainManager _instance = new MainManager();
        public static MainManager Instance 
        {
            get 
            { 
                return _instance; 
            }
        }

        public Students students = new Students();
        public void Init()
        {
            students.LoadStudents();
        }
    }
}
