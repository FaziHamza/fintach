using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.BLL
{
    public class Users
    {
        #region User Details Section
        public static int AddUser(tblUser users,tblContactInfoAccountDetails contactInfoAccountDetails,
                                   tblContactInfoBusiness contactInfoBusiness,tblIdentifiaction identifiaction,tblLegalInfo legalInfo, 
                                   tblResidence residence, tblSecure secure)
        {
            using (AscentContext context = new AscentContext())
            {
                context.tblContactInfoAccountDetails.Add(contactInfoAccountDetails);
                context.tblContactInfoBusiness.Add(contactInfoBusiness);
                context.tblIdentifiaction.Add(identifiaction);
                context.tblLegalInfo.Add(legalInfo);
                context.tblResidence.Add(residence);
                context.tblSecure.Add(secure);
                context.tblUser.Add(users);
                int id = context.SaveChanges();// (bool)Save();
                return id;
            }
        }
        public static List<tblUser> GetAllUsers()
        {
            using (AscentContext context = new AscentContext())
            {
                return context.tblUser.Include(x=>x.tblContactInfoAccountDetails).Include(x => x.tblContactInfoBusiness).Include(x => x.tblIdentifiaction).Include(x => x.tblLegalInfo).Include(x => x.tblResidence).Include(x => x.tblSecure).ToList();
            }
        }
        
        public static tblIdentifiaction GetUserName(long userId)
        {
            using (AscentContext context = new AscentContext())
            {
                return context.tblIdentifiaction.Where(x=>x.UserId == userId).FirstOrDefault();
            }
        }
        
        public static bool Login(tblUser user)
        {
            using (AscentContext context = new AscentContext())
            {
                var result= context.tblUser.Include(x => x.tblIdentifiaction).Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
                if (result != null)
                {
                    user.tblIdentifiaction= GetUserName(result.UserId);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

        #region Transaction
        public static object Save()
        {
            object id = 0;
            using (AscentContext context = new AscentContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        id = context.SaveChanges();
                        dbContextTransaction.Commit();
                        return id;
                    }
                    catch (Exception)
                    {
                        //Log Exception Handling message                      
                        dbContextTransaction.Rollback();
                        return id;
                    }
                }
            }
        }
        #endregion
    }
}
