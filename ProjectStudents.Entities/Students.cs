using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectStudents.Model;
using ProjectStudents.DAL;

namespace ProjectStudents.Entities
{
    public class Students:BaseEntity
    {
        Hashtable studentsTable = new Hashtable();

        //Load the HashTable with Data from DB Students
        public void LoadStudents()   
        {
            try
            {
                SqlQuery.RunCommandResult("select StudentID, Name, Age, Address from Students", AddStudentToHashTable);
            }
             catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public object AddStudentToHashTable(SqlDataReader reader)
        {
            studentsTable.Clear();

            while (reader.Read())
            {
                Student student = new Student();

                student.Id = reader.GetInt32(reader.GetOrdinal("StudentID"));
                student.Name = reader.GetString(reader.GetOrdinal("Name"));
                student.Age = reader.GetInt32(reader.GetOrdinal("Age"));
                student.Address = reader.GetString(reader.GetOrdinal("Address"));

                studentsTable.Add(student.Id, student);
            }

            return studentsTable;
        }

        //Insert new Data(Student) to the DB Students
        public void InsertNewStudentToDB(int id, string name, int age, string address)
        {
            try
            {
                if (!studentsTable.ContainsKey(id))
                {
                    Student student = new Student() { Id = id, Name = name, Age = age, Address = address };
                    DAL.SqlQuery.RunNonQuery($"insert into Students (StudentID, Name, Age, Address) values({id}, '{name}', {age}, '{address}')");
                    studentsTable.Add(student.Id, student);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Get Student from HashTable
        public Student GetStudentFromHashTable(int id)
        {
            try
            {
                if (studentsTable.ContainsKey(id) && studentsTable[id] is Student)
                {
                    Student student = (Student)studentsTable[id];
                    return student;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
