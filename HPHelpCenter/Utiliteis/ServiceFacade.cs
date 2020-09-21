using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dal;
using HPHelpCenter.Models;
using HPHelpCenter.Dal;
using System.Drawing;

namespace HPHelpCenter
{
    // Implemens Singleton Design Pattern
    class ServiceFacade
    {
        private UserHandler userHandler;
        private TopicHandler topicHandler;
        private IssueHandler issueHandler;
        private SolutionHandler solutionHandler;
        private PictureHandler pictureHandler;
        private ItemHandler itemHandler;

        private ServiceFacade()
        {
            DBHelper dbHelper = new DBHelper("dbHelper");
            this.userHandler = new UserHandler(dbHelper);
            this.topicHandler = new TopicHandler(dbHelper);
            this.issueHandler = new IssueHandler(dbHelper);
            this.solutionHandler = new SolutionHandler(dbHelper);
            this.pictureHandler = new PictureHandler(dbHelper);
            //this.itemHandler = new ItemHandler(dbHelper);
        }

        private static ServiceFacade instance;
        
        private User userDetails = null;
        private Image image = null;

        public static ServiceFacade getInstance()
        {
            if (instance == null)
            {
                instance = new ServiceFacade();
                //DAL dal = DAL.GetInstance();
                //dal.AddTable("User");
            }
            return instance;
        }
        // זיהוי משתמש
        internal bool authenticate(string userName, string password)
        {
            userDetails = userHandler.GetUsersByUserNameAndPassword(userName, password);
            if (userDetails != null)
            {
                if (userDetails.PictureID > 0) {
                    Picture picture = pictureHandler.GetBusinessEntityById(userDetails.PictureID);
                    if (picture != null)
                    {
                        ImageConverter converter = new ImageConverter();
                        image = (Image)converter.ConvertFrom(picture.Img);
                    }
                }
                return true;
            }
            else
            {
                return false;
            } 
        }

        public Image GetMyImage()
        {
            return image;
        }

        internal bool isCrew()
        {
            if (userDetails.Role == User.UserRole.Crew) { return true; }
            else { return false; }
        }
        internal User getUserDetails()
        {
            return userDetails;
        }
        internal void SaveUser(User u)
        {
            ValidateUser(u);
            User user = getUserDetails();
            user.FirstName = u.FirstName;
            user.LastName = u.LastName;
            user.UserName = u.UserName;
            user.Password = u.Password;
            user.Email = u.Email;
            user.BirthdayDate = u.BirthdayDate;
            user.Country = u.Country;
            user.Gender = u.Gender;
            user.PictureID = u.PictureID;

            userHandler.UpdateBusinessEntity(user);
        }
        internal List<Issue> SearchIssue(string keyWord)
        {
            return issueHandler.GetIssues(keyWord);
        }
        internal void AddItem(Item item)
        {
           // itemHandler.CreateBusinessEntity(item);
        }
        internal void CheckSaveUser(User user)
        {
            ValidateUser(user);
            if (!IsLegalUserName(user.UserName))
            {
                throw new Exception("Username already exist. Try another username");
            }
            userHandler.CreateBusinessEntity(user);
        }

        private void ValidateUser(User user)
        {
            if (!IsLegalEmail(user.Email))
            {
                throw new Exception("Wrong email. Must be <usernam>@<sub-domain>.<dmain>");
            }
            if (!ISLegalBirthday(user.BirthdayDate))
            {
                throw new Exception("Wrong birthday. You must be at least 18 years old");
            }
            if (!IsLegalName(user.FirstName, 1))
            {
                throw new Exception("Wrong first name. Non letter characters are not allowed here");
            }
            if (!IsLegalName(user.LastName, 1))
            {
                throw new Exception("Wrong last name. Non letter characters are not allowed here");
            }
            if (!ISLegalPassword(user.Password))
            {
                throw new Exception("Wrong password. Must containe at least 6 characters");
            }
        }
        internal List<User> FindUsers(string userName)
        {
            return userHandler.GetUsersByUserName(userName);
        }
        internal List<Topic> GetTopics()
        {
            return topicHandler.GetAllTopics();
        }
        internal List<Issue> SearchIssue(string keyWord, int id)
        {
            return issueHandler.GetIssues(keyWord, id);
        }
       /*internal List<Issue> GetIssue()
        {
            return issueHandler.GetIssues();
        }*/
        internal bool isProg()
        {
            if (userDetails.Role == User.UserRole.Programmer) { return true; }
            else { return false; }
        }

        internal List<User> AllUsers()
        {
            return userHandler.GetAllUsers();
        }

        internal void AddIssue(Issue issue)
        {
            issue.ID = (Int32)((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) & 0xFFFF);
            issue.IsDeleted = false;
            issueHandler.CreateBusinessEntity(issue);
        }

        internal Issue GetIssue(int issueId)
        {
            return issueHandler.GetBusinessEntityById(issueId);
        }

        internal User getUserByID(int userID)
        {
            return userHandler.GetBusinessEntityById(userID);
        }

        internal List<Solution> GetSolutions(int issueID)
        {
            return solutionHandler.GetSolutionsById(issueID);
        }

        internal void AddSolution(Solution solution)
        {
            solution.ID = (Int32)((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) & 0xFFFF);
            solution.Status = false;
            solution.SubDate = DateTime.Now;
            solution.UserID = getUserDetails().ID;
            solutionHandler.CreateBusinessEntity(solution);
        }

        internal void AddTopic(Topic topic)
        {
            topic.ID = (Int32)((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) & 0xFFFF);
            topicHandler.CreateBusinessEntity(topic);
        }

        internal List<Topic> SearchTopics(string keyWord)
        {
            return topicHandler.GetTopics(keyWord);
        }

        internal List<Issue> GetIssues(bool b)
        {
            return issueHandler.GetAllIssues(b);
        }

        internal List<Issue> GetIssuesByCountry(bool b)
        {
            return issueHandler.GetAllIssuesByContry(b);
        }

        internal List<Issue> GetIssuesByUser(int userId, bool b)
        {
            return issueHandler.GetIssueByUserId(userId, b);
        }

        internal void UpdateUser(User user)
        {
            ValidateUser(user);
            userHandler.UpdateBusinessEntity(user);
        }

        internal void DeleteUser(User user)
        {
            user.IsDeleted = true;
            userHandler.UpdateBusinessEntity(user);
        }

        internal Topic GetTopics(int p)
        {
            return topicHandler.GetBusinessEntityById(p);
        }

        internal void UpdateTopic(Topic topic)
        {
            topicHandler.UpdateBusinessEntity(topic);
        }

        internal void DeleteTopic(Topic topic)
        {
            topic.IsDeleted = true;
            topicHandler.UpdateBusinessEntity(topic);
        }

        internal void UpdateSolution(Solution solution)
        {
            solutionHandler.UpdateBusinessEntity(solution);
        }

        //Checking user
        internal bool ISLegalBirthday(DateTime dt)
        {
            if ((dt.Year >= (DateTime.Now.Year - 120)) && (dt.Year <= (DateTime.Now.Year - 18)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool IsLegalEmail(string e)
        {
            int count = 0;
            for (int i = 0; i < e.Length; i++)
            {
                if (e[i] == '@')
                    count++;
            }
            if (count == 1)
                return true;
            return false;
        }
        internal bool IsLegalUserName(string st)
        {
            List<User> user = userHandler.GetAllUsers();
            foreach (User u in user)
                if (st.Equals(u.UserName))
                    return false;
            return true;
        }
        //Cheking first or last name 
        internal bool IsLegalName(string st, int i)
        {
            foreach (char c in st)
                if (!IsEnglishChar(c , i))
                    return false;
            return true;
        }
        internal bool ISLegalPassword(string st)
        {
            if (st.Length < 6)
                return false;
            return true;
        }
        internal bool IsEnglishChar(char ch, int i)
        {
            if (i == 1)
            {
                return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z');
            }
            else
            {
                return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch=='@') || (ch=='!') || (ch=='#') ||
                    (ch=='$') || (ch=='%') || (ch=='^') || (ch=='&') || (ch=='*') || (ch=='(') || (ch==')') || (ch=='[')
                    || (ch==']') || (ch=='@') || (ch=='{') || (ch=='}') || (ch=='"') || (ch=='\'') || (ch=='/') ||
                    (ch==':') || (ch=='\\') || (ch==',') || (ch=='.') || (ch=='-') ||(ch=='_') || (ch=='=') ||    
                    (ch=='+') || (ch=='~') || (ch==';') || (ch=='>') || (ch=='<');
                }
        }


        internal Image SaveUserPicture(byte[] bytes)
        {
            // 1. generate picture Id
            int id = (Int32)((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) & 0xFFFF);
            Picture picture = new Picture(id, bytes);
            // 2. save picture with PictureHandler
            pictureHandler.CreateBusinessEntity(picture);
            // 3. delete old picture by picture id from the user object.
            if (userDetails.PictureID > 0)
            {
                pictureHandler.DeleteBusinessEntity(new Picture(userDetails.PictureID, null, true));
            }
            // 4. Update user with pictureID
            userDetails.PictureID = id;
            userHandler.UpdateBusinessEntity(userDetails);
            ImageConverter converter = new ImageConverter();
            image = (Image)converter.ConvertFrom(bytes);
            return image;
        }

        internal string GetItem(int p)
        {
            throw new NotImplementedException();
        }
    }
}
