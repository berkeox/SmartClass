using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.IO;



namespace Smart_Class
{
   public  static  class DBOperations
    {
        static SqlConnection sqlConnection = new SqlConnection("Data Source=P-X\\SQLEXPRESS;Initial Catalog=SmartClass;Integrated Security=True");
        public static void AddQuestion(Question question)
        {
            sqlConnection.Open();
            SqlCommand addQuestion = new SqlCommand("INSERT INTO Question(description,questionText,subject,correctAnswer,falseAnswerFirst,falseAnswerSecond,falseAnswerThird,image) VALUES('"+question.description+"','"+question.questionText+ "','"+question.subject+ "','"+question.correctAnswer+ "','"+question.falseAnswerFirst+ "','"+question.falseAnswerSecond+ "','"+question.falseAnswerThird+ "','"+question.questionPicture+"')",sqlConnection);
            addQuestion.ExecuteNonQuery();
            addQuestion.Dispose();
            sqlConnection.Close();
        }
        public static bool CheckTeacher(string email,string password)
        {
            sqlConnection.Open();
            SqlCommand checkTeacher = new SqlCommand("SELECT trim(teacherName),trim(teacherSurname),trim(teacherEmail),trim(teacherBranch) FROM Teacher WHERE teacherEmail=@p1 AND teacherPassword=@p2  ", sqlConnection);
            checkTeacher.Parameters.AddWithValue("@p1", email);
            checkTeacher.Parameters.AddWithValue("@p2", password);
            SqlDataReader dr = checkTeacher.ExecuteReader();
           // SqlDataAdapter da = new SqlDataAdapter(checkTeacher);
          //  DataSet ds = new DataSet();
           // da.Fill(ds);
            while (dr.Read())
            {
               // MemoryStream ms = new MemoryStream((byte[])ds[4]["Image"]);
               // new Bitmap(ms);
               Teacher.GetInstance(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            sqlConnection.Close();
            if(Teacher.GetInstance()!=null)
            {
                return true;
            }

            return false;  

        }
        public static bool CheckStudent(string email, string password)
        {
            sqlConnection.Open();
            SqlCommand checkStudent = new SqlCommand("SELECT trim(studentName),trim(studentSurname),trim(studentEmail) FROM Student WHERE studentEmail=@p3 AND studentPassword=@p4 ", sqlConnection);
            checkStudent.Parameters.AddWithValue("@p3", email);
            checkStudent.Parameters.AddWithValue("@p4", password);
            SqlDataReader db = checkStudent.ExecuteReader();
            while(db.Read())
            {
                Student.GetInstance(db[0].ToString(), db[1].ToString(), db[2].ToString());
            }
            sqlConnection.Close();
            if(Student.GetInstance()!=null)
            {
                return true;
            }
            return false;
        }

        public static LinkedList<Question> GetQuestions()
        {
            LinkedList<Question> questions =new LinkedList<Question>();
            sqlConnection.Open();
            SqlCommand getQuestions = new SqlCommand("SELECT trim(description),trim(questionText),trim(correctAnswer),trim(falseAnswerFirst),trim(falseAnswerSecond),trim(falseAnswerThird),trim(subject) FROM Question", sqlConnection);
            SqlDataReader dr = getQuestions.ExecuteReader();

            while(dr.Read())
            {
                Question newQuestion = new Question(dr[0].ToString(),dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), null);
                questions.AddLast(newQuestion);
            }
            sqlConnection.Close();

            return questions;

        }
    }
}
