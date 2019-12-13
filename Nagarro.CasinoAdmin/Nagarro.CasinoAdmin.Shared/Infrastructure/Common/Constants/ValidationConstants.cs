using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.CasinoAdmin.Shared
{
   public class ValidationConstants
    {
        //public const string PasswordRegEx = @"^[a-zA-Z0-9!@#$%^&*~?.]$";
       public static string Common = "Common";
       public static string Admin = "Admin";
       public static string CreateUser = "CreateUser";
       public static string FirstNameEmpty = "First Name should not be empty";
       public static string FirstNameRules = "First Name should be less than 50 characters";
       public static string LastNameEmpty = "Last Name should not be empty";
       public static string LastNameRules = "Last Name should be less than 50 characters";
       public static string DateOfJoining = "Date should not be empty";
       public static string ExpirationDate = "Expiration Date Should Be greater than start date";
       public static string Department = "Department id should not be empty";
       public static string Password = "Password should not be empty";
       public static string PasswordRules = "Password should be in between 8 to 16 characters";
       public static string PasswordRule2 = "It should have at-least one numeric character and one special character out of (!, @, #, $, %, ^, &, *, ~, ?, .) ";
       public static string Email = "Email should not be empty";
       public static string UniqueEmail = "Email already exist";
       public static string CommentRules = "Comment should be less than 500 characters";
       public static string AssignedToRules = "Issue assigned to should not be empty";
       public static string StatusRule = "Status should not be empty";
       public static string StatusRule2 = "Status should be 1-3";
       public static string IssueTitle = "Title should not be empty.";
       public static string IssueTitleRule = "Title should be less than 100 characters";
       public static string IssueDescription = "Description should not be empty.";
       public static string IssueDescriptionRule = "Description should not be less than 500 characters";
       public static string Priority = "Priority should not be empty";
       public static string PriorityRules = "Priority should be 1-3";
       public static string NoticeTitle = "Title should not be empty.";
       public static string NoticeTitleRules = "Title should be less than 100 characters";
       public static string NoticeDescription = "Description should not be empty.";
       public static string NoticeDescriptionRules = "Description should not be less than 500 characters";
       public static string NoticeStartDate = "Start Date should not be empty.";
       public static string NoticeExpirationDate = "Expiration date should not be empty.";
       public static string NoticeExpirationDateRules = "Expiration date should be greater than start date";
       public static string GetCurrentNoticeFailure = "Unable to get current notices";
       public static string GetActiveNoticeFailure = "Get Active notices failed";
       public static string DeleteNoticeFailure = "Deletion Failed";
       public static string UpdateNoticeSuccess = "Notice updated successfully";
       public static string UpdateNoticeFailure = "Update Notice failed";
       public static string CreateNoticeSuccess = "Notice Created successfully";
       public static string CreateNoticeFailure = "Create Notice Failed";
       public static string CreateIssueSuccess = "Issue Created Successfully";
       public static string CreateIssueFailure = "Create issue failed";
       public static string DeleteIssueFailed = "Delete issue failed";
       public static string UpdateIssueSuccess = "Issue Updated Successfully";
       public static string UpdateIssueFailed = "Issue Update failed";
       public static string GetIssueFailed = "Get issue failed";
       public static string GetDepartmentFailed = "Get Department Failed";
       public static string CreateUserFailed = "Create user failed";
       public static string SearchUserFailed = "Search User failed";
       public static string GetUserByEmailFailed = "get user by email failed";
       public static string UpdateUser = "UpdateUser";
    }
}
