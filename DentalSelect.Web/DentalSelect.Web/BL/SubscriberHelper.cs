using DentalSelect.Web.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DentalSelect.Web.BL
{    
    /// <summary>
    /// Static helper class used for Business Logic
    /// </summary>
    public static class SubscriberHelper
    {
        /// <summary>
        /// Gets a list of Subscribers always ordered by First Name
        /// </summary>
        /// <param name="searchString">Searches the Zip Code</param>
        /// <returns>List of Subscribers</returns>
        public static List<Subscriber> GetSubscribers(string searchString)
        {
            var subscribers = new List<Subscriber>();
            try
            {
                using (var db = new DentalSelectWebContext())
                {                    
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        subscribers = db.Subscribers
                            .Where(s => s.ZipCode.Contains(searchString))
                            .OrderBy(s => s.FirstName)
                            .ToList();
                    }
                    else
                    {
                        subscribers = db.Subscribers
                            .OrderBy(s => s.FirstName)
                            .ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                // Placeholder for real logging...
                Console.WriteLine(ex.Message);
                throw;
            }
            return subscribers;
        }

        /// <summary>
        /// Adds a Subscriber 
        /// </summary>
        /// <param name="subScriber"></param>
        public static void AddSubscriber(Subscriber subScriber)
        {
            try
            {
                using (var db = new DentalSelectWebContext())
                {
                    db.Subscribers.Add(subScriber);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Placeholder for real logging...
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Finds a Subscriber if one exists
        /// </summary>
        /// <param name="id">Id of the Subscriber</param>
        /// <returns>Returns SuSubscriber if one exists otherwise null</returns>
        public static Subscriber FindSubscriber(int id)
        {
            var subscriber = new Subscriber();
            try
            {
                using (var db = new DentalSelectWebContext())
                {
                    subscriber = db.Subscribers.Find(id);
                }
            }
            catch (Exception ex)
            {
                // Placeholder for real logging...
                Console.WriteLine(ex.Message);
                throw;
            }
            return subscriber;
        }

        /// <summary>
        /// Deletes a Subscriber
        /// </summary>
        /// <param name="id">Id of the Subscriber</param>
        public static void DeleteSubscriber(int id)
        {
            try
            {
                using (var db = new DentalSelectWebContext())
                {
                    Subscriber subscriber = db.Subscribers.Find(id);
                    db.Subscribers.Remove(subscriber);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Placeholder for real logging...
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}