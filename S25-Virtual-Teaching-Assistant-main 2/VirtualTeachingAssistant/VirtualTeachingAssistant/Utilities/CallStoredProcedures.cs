using Npgsql; 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTAModelLibrary;

public class CallingStoredProcedures
{

		//GET - Account by ID
	public DataTable GetAccountByID(Account getAccount)
	{

        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


		accSQL.CommandType = CommandType.StoredProcedure;
		accSQL.CommandText = "get_account_by_id";

		DBConnect loginDB = new DBConnect();

		accSQL.Parameters.AddWithValue("@accountid", getAccount.ID);


		DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
		dtAccResult = dsAccResult.Tables[0];

		return accResult;
	}


		//INSERT - Account New
	public bool AddNewAccount(Account newAccount)
	{
        //Check if the account actually exists 
		NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {



            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_account";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_account_name", newAccount.AccountName);
            accSQL.Parameters.AddWithValue("@p_account_password", newAccount.Password);
            accSQL.Parameters.AddWithValue("@p_first_name", newAccount.FirstName);
            accSQL.Parameters.AddWithValue("@p_last_name", newAccount.LastName);
            accSQL.Parameters.AddWithValue("@p_email", newAccount.Email);

        } catch(Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }


    //UPDATE - Account Update 
    public bool UpdateAccount(Account updateAccount)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool updateSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "update_account";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_account_id", updateAccount.ID);
            accSQL.Parameters.AddWithValue("@p_account_name", updateAccount.AccountName);
            accSQL.Parameters.AddWithValue("@p_account_password", updateAccount.Password);
            accSQL.Parameters.AddWithValue("@p_first_name", updateAccount.FirstName);
            accSQL.Parameters.AddWithValue("@p_last_name", updateAccount.LastName);
            accSQL.Parameters.AddWithValue("@p_email", updateAccount.Email);

        }
        catch (Exception ex)
        {
            updateSuccess = false;
        }

        return updateSuccess;
    }

    //DELETE - Account Delete 
    public bool DeleteAccount(Account deleteAccount)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_account";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_account_id", updateAccount.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;
    }

    //get professor by id 
    //add professor model?
    public DataTable GetProfessorByID(Account getAccount)
    {
        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


        accSQL.CommandType = CommandType.StoredProcedure;
        accSQL.CommandText = "get_professor_by_id";

        DBConnect loginDB = new DBConnect();

        accSQL.Parameters.AddWithValue("@p_professor_id", getAccount.ID);


        DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
        dtAccResult = dsAccResult.Tables[0];

        return accResult;
    }

    //insert into professor 
    public bool AddProfessor(Account profAccount)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {



            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_professor";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@accountid", profAccount.AccountID);

        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //delete professor 
    public bool DeleteProfessor(Account deleteAccount)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_professor";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_professor_id", deleteAccount.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;
    }

    //get student by id 
    public DataTable GetStudentByID(Student studentAcc)
    {
        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


        accSQL.CommandType = CommandType.StoredProcedure;
        accSQL.CommandText = "get_account_by_id";

        DBConnect loginDB = new DBConnect();

        accSQL.Parameters.AddWithValue("@p_student_id", studentAcc.ID);


        DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
        dtAccResult = dsAccResult.Tables[0];

        return accResult;
    }

    //insert into student 
    public bool AddStudent(Student studentAcc)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {



            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_account";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_student_year", studentAcc.Year);
            accSQL.Parameters.AddWithValue("@p_account_id", studentAcc.ID);

        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //delete student 
    public bool DeleteStudent(Student studentAcc)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_student";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_student_id", studentAcc.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;
    }

    //get course by id
    public DataTable GetCourseByID(Course courseAcc)
    {
        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


        accSQL.CommandType = CommandType.StoredProcedure;
        accSQL.CommandText = "get_course_by_id";

        DBConnect loginDB = new DBConnect();

        accSQL.Parameters.AddWithValue("@p_course_id", courseAcc.ID);


        DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
        dtAccResult = dsAccResult.Tables[0];

        return accResult;
    }

    //insert into courses 
    public bool AddCourse(Course courseAcc)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {



            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_course";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_course_title", courseAcc.Title);
            accSQL.Parameters.AddWithValue("@p_subject", courseAcc.Subject);
            accSQL.Parameters.AddWithValue("@p_semester", courseAcc.Semester);
            accSQL.Parameters.AddWithValue("@p_year", courseAcc.Year);


        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;

    }

    //delete course 
    public bool DeleteCourse(Course courseAcc)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_course";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_course_id", courseAcc.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;
    }

    //get request by id 
    public DataTable GetRequest(Request request)
    {
        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


        accSQL.CommandType = CommandType.StoredProcedure;
        accSQL.CommandText = "get_request_by_id";

        DBConnect loginDB = new DBConnect();

        accSQL.Parameters.AddWithValue("@p_request_id", request.ID);


        DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
        dtAccResult = dsAccResult.Tables[0];

        return accResult;
    }

    //insert into requests 
    public bool AddRequest(Request request)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {



            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_request";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_course_id", request.ID);
            accSQL.Parameters.AddWithValue("@p_request_body", request.Body);
            accSQL.Parameters.AddWithValue("@p_request_type", request.Type);
            accSQL.Parameters.AddWithValue("@p_chat_id", request.ChatID);


        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //delete request
    public bool DeleteRequest(Request request)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_request";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_request_id", request.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;
    }

    //get request history by id 
    public DataTable GetReqHistoryByID(Request request)
    {
        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


        accSQL.CommandType = CommandType.StoredProcedure;
        accSQL.CommandText = "get_request_history_by_id";

        DBConnect loginDB = new DBConnect();

        accSQL.Parameters.AddWithValue("@p_request_id", request.ID);


        DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
        dtAccResult = dsAccResult.Tables[0];

        return accResult;
    }

    //insert into request history 
    public bool AddRequestHistory(Request request)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {



            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_request_history";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_request_id", request.ID);
            accSQL.Parameters.AddWithValue("@p_response", request.Body);


        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //delete request history 
    public bool DeleteRequestHistory(Request request)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_request_history";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_request_id", request.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;
    }

    //get file by id 
    public DataTable GetFileByID(CourseFile file)
    {
        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


        accSQL.CommandType = CommandType.StoredProcedure;
        accSQL.CommandText = "get_file_by_id";

        DBConnect loginDB = new DBConnect();

        accSQL.Parameters.AddWithValue("@p_file_id", request.ID);


        DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
        dtAccResult = dsAccResult.Tables[0];

        return accResult;
    }

    //insert into files
    public bool AddFile(CourseFile file)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {



            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_file";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_course_id", file.ID);
            accSQL.Parameters.AddWithValue("@p_file_link", file.FileLink);
            accSQL.Parameters.AddWithValue("@p_file_assignment_category", file.AssignmentCategory);

        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //delete file 
    public bool DeleteFile(CourseFile file)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_file";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_file_id", file.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;

    }

    //get course file by id 
    public DataTable GetCourseFileByID(CourseFile file)
    {
        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


        accSQL.CommandType = CommandType.StoredProcedure;
        accSQL.CommandText = "get_course_file_by_id";

        DBConnect loginDB = new DBConnect();

        accSQL.Parameters.AddWithValue("@p_file_id", request.ID);


        DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
        dtAccResult = dsAccResult.Tables[0];

        return accResult;
    }

    //insert ito course files 
    public bool AddCourseFile(CourseFile file)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {



            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_file";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_file_id", file.ID);
            accSQL.Parameters.AddWithValue("@p_course_id", file.CourseID);

        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //delete course files 
    public bool DeleteCourseFile(CourseFile file)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_course_file";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_file_id", file.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;
    }

    //get request by id 
    public DataTable GetStudentRequestByID(Request request, Student studentReq)
    {
        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


        accSQL.CommandType = CommandType.StoredProcedure;
        accSQL.CommandText = "get_student_request_by_id";

        DBConnect loginDB = new DBConnect();

        accSQL.Parameters.AddWithValue("@p_student_id", studentReq.ID);
        accSQL.Parameters.AddWithValue("@p_request_id", request.ID);


        DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
        dtAccResult = dsAccResult.Tables[0];

        return accResult;
    }

    //insert into student req
    public bool AddStudentReq(Request request, Student studentReq)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {



            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_student_request";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_student_id", studentReq.ID);
            accSQL.Parameters.AddWithValue("@p_request_id", request.CourseID);
            accSQL.Parameters.AddWithValue("@p_priority_level", request.Status);
        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //delete student req
    public bool DeleteStudentReq(Request request, Student studentReq)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_student_request";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_student_id", studentReq.ID);
            accSQL.Parameters.AddWithValue("@p_request_id", request.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;
    }

    //get prof by id 
    public DataTable GetProfCourseByID(Professor professor, Course course)
    {
        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


        accSQL.CommandType = CommandType.StoredProcedure;
        accSQL.CommandText = "get_professor_course_by_id";

        DBConnect loginDB = new DBConnect();

        accSQL.Parameters.AddWithValue("@p_professor_id", professor.ID);
        accSQL.Parameters.AddWithValue("@p_course_id", course.ID);


        DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
        dtAccResult = dsAccResult.Tables[0];

        return accResult;
    }

    //insert into prof course 
    public bool AddProfCourse(Professor professor, Course course)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_student_request";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_professor_id", professor.ID);
            accSQL.Parameters.AddWithValue("@p_course_id", course.ID);
        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //delete prof course 
    public bool DeleteProfCourse(Professor professor, Course course)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_professor_course";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_professor_id", professor.ID);
            accSQL.Parameters.AddWithValue("@p_course_id", course.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;
    }

    //get student course by id 
    public DataTable GetStudentCourseByID(Student student, Course course)
    {
        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


        accSQL.CommandType = CommandType.StoredProcedure;
        accSQL.CommandText = "get_student_course_by_id";

        DBConnect loginDB = new DBConnect();

        accSQL.Parameters.AddWithValue("@p_student_id", student.ID);
        accSQL.Parameters.AddWithValue("@p_course_id", course.ID);

        DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
        dtAccResult = dsAccResult.Tables[0];

        return accResult;
    }

    //insert into student course
    public bool InsertStudentCourse(Student student, Course course)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_student_course";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_student_id", student.ID);
            accSQL.Parameters.AddWithValue("@p_course_id", course.ID);
        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //delete student course 
    public bool DeleteStudentCourse(Student student, Course course)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_professor_course";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_student_id", student.ID);
            accSQL.Parameters.AddWithValue("@p_course_id", course.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;
    }

    //get ta course by id 
    public DataTable GetTACourseByID(Account teachingAssistant, Course course)
    {
        DataTable dtAccResult = new DataTable();
        NpgsqlCommand accSQL = new NpgsqlCommand();


        accSQL.CommandType = CommandType.StoredProcedure;
        accSQL.CommandText = "get_ta_course_by_id";

        DBConnect loginDB = new DBConnect();

        accSQL.Parameters.AddWithValue("@p_ta_id", teachingAssistant.ID);
        accSQL.Parameters.AddWithValue("@p_course_id", course.ID);

        DataSet dsAccResult = loginDB.GetDataSetUsingCmdObj();
        dtAccResult = dsAccResult.Tables[0];

        return accResult;
    }

    //insert into course 
    public bool AddTACourse(Account teachingAssistant, Course course)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "insert_ta_course";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_ta_id", teachingAssistant.ID);
            accSQL.Parameters.AddWithValue("@p_course_id", course.ID);
        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //delete course 
    public bool DeleteTACourse(Account teachingAssistant, Course course)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool deleteSuccess = true;

        try
        {

            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "delete_ta_course";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_ta_id", teachingAssistant.ID);
            accSQL.Parameters.AddWithValue("@p_course_id", course.ID);

        }
        catch (Exception ex)
        {
            deleteSuccess = false;
        }

        return deleteSuccess;
    }

    //update course
    public bool UpdateTACourse(Course course)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {
            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "update_course";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_course_id", course.ID);
            accSQL.Parameters.AddWithValue("@p_course_title", course.Title);

            accSQL.Parameters.AddWithValue("@p_subject", course.Subject);
            accSQL.Parameters.AddWithValue("@p_semester", course.semester);
            accSQL.Parameters.AddWithValue("@p_year", course.Year);
        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //update req
    public bool UpdateRequest(Request request)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {
            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "update_request";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_request_id", request.ID);
            accSQL.Parameters.AddWithValue("@p_course_id", request.CourseID);            accSQL.Parameters.AddWithValue("@p_request_body", request.Body);
            accSQL.Parameters.AddWithValue("@p_request_type", request.Type);
            accSQL.Parameters.AddWithValue("@p_request_status", request.Status);
            accSQL.Parameters.AddWithValue("@p_chat_id", request.ChatID);
        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //update file 
    public bool UpdateFile(CourseFile file)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        {
            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "update_file";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_file_id", file.ID);
            accSQL.Parameters.AddWithValue("@p_course_id", file.CourseID);
            accSQL.Parameters.AddWithValue("@p_file_link", file.Link);
            accSQL.Parameters.AddWithValue("@p_file_assignment_category", file.Category);
        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }

    //update student req priority 
    public bool UpdateReqPriority(Request request)
    {
        //Check if the account actually exists 
        NpgsqlCommand accSQL = new NpgsqlCommand();
        bool insertSuccess = true;

        try
        try
        {
            accSQL.CommandType = CommandType.StoredProcedure;
            accSQL.CommandText = "update_student_request_priority";

            DBConnect loginDB = new DBConnect();

            accSQL.Parameters.AddWithValue("@p_student_id", request.StudentID);
            accSQL.Parameters.AddWithValue("@p_request_id", request.ID); 
            accSQL.Parameters.AddWithValue("@p_priority_level", request.Status);
        }
        catch (Exception ex)
        {
            insertSuccess = false;
        }

        return insertSuccess;
    }


}
