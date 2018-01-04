# Dental Select Test
This repository contains an extremely simple MVC app that is the result of a take home test.

# Exec Summary
So we have "Make it work, make it right, and make it fast"  This repo is at make it work.  I kept things very simple with simple views and no dynmaic loading.  

**The GUI and workflow are terrible, I had questions, but didn't think it was important to have a clean GUI as per spec.**

**This is by no means PRODUCTION Ready!!!**

# Things to be Aware of...
  * Test spec file and other system files found at root.
  * Subscribers table SQL creation script found at root (Subscribers_Table_Creation_20180103.sql)
  * Business logic does not contain any logging, but the error handling and logging logic are in place to be extended.  
  * The DAL and BL logic could be put into seperate projects but was kept in one project for simplicity.  

# Steps to run
 * Clone the repo.
 * Restore NuGet Packages.
 * Manually create Forms DB in local solution App_Data folder.
 * Use Subscribers_Table_Creation_20180103.sql to create Subscribers table
 * Run the app, you should be good to go :-)
