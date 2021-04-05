using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    public static List<string> Question = new List<string>();
    public static List<int> QNo = new List<int>();
    public static List<string> QAns = new List<string>();
    public System.Random ran = new System.Random();

    void Start()
    {
        Question.Add("State the he clause that enables mapping a short command to a long command is ____\n a)	MAP\n b)DIRECT\n c)LABEL\n d)ALIAS");QAns.Add("d");
        Question.Add("Identify the statement is used to select a default database?\n a) USE\n b) CREATE\n c) DROP\n d) SCHEMA"); QAns.Add("a");
        Question.Add("Identify which keyword is used to create a database?\n a)CREATE\n b)SET\n c)SETUP\n d) LINK"); QAns.Add("a");
        Question.Add("Interpret the keyword used to create a database only if it doesn’t already exist, which clause is used?\n a) IF EXISTS\n b) IF NOT EXISTS\n c) CREATE EXISTS\n d) EXISTS IF");QAns.Add("b");
        Question.Add("Identify if in the CREATE TABLE statement, the engine name specified is case sensitive.\n a) True\n b) False");QAns.Add("b");
        Question.Add("Identify the  statement makes changes to the database’s global attributes?\n a) CHANGE\n b) ALTER\n c) ALTERNATE\n d) UPDATE");QAns.Add("b");
        Question.Add("Recognize the  statement used to see the definition for an existing database?\n a) SHOW CREATE DATABASE\n b) SHOW DATABASE\n c) SHOW CREATE\n d) SHOW CREATE DATABASE TABLE"); QAns.Add("a");
        Question.Add("Identify if it is  possible to drop multiple tables in the same statement.\n a) True\n b) False");QAns.Add("a");
        Question.Add("Select the statement used to change the table name ____\n a) CHANGE\n b) CHANGENAME\n c) ALTER\n d) RENAME");QAns.Add("d");
        Question.Add("Identify the table that displays data redundancies yields ____ anomalies.\n a. Update\n b. Insertion\n c. Deletion\n d. All of the Mentioned"); QAns.Add("d");
        Question.Add("Select the sequence for how the query mechanism works?\n a. Authentication-> DDL->DML->query optimizer->output\n b. DDL->DML->query optimizer-> Authentication->output\n c. DML->query optimizer-> Authentication-> DDL-> output\n d. All of the mentioned"); QAns.Add("a");
        Question.Add("State a data manipulation command the combines the records from one or more tables is called\n a. SELECT\n b. PROJECT\n c. JOIN\n d. PRODUCT"); QAns.Add("a");
        Question.Add("State DCL consists of how many commands\n a) 3\n b) 5\n c) 2\n d) 4"); QAns.Add("c");
        Question.Add("Identify DCL is used to control __ in database.\n a) Privileges\n b) Controls\n c) System\n d) Clients"); QAns.Add("b");
        Question.Add("Select  which of these examples of privileges are CREATE SESSION, CREATE TABLE, CREATE USER? \n a.	Object Privileges\n b.	System Privileges\n c.	User Privileges\n d.	None of the Above");QAns.Add("b");
        Question.Add("State which of these statements create session to username? \n a.	Grant\n b.	Revoke\n c.	Permit\n d.	Create");QAns.Add("a");
        Question.Add("State the purpose of Order By Clause in SQL server?\n a) It is used to sort the result.\n b) It is used to change sequence order of columns\n c) It can’ be used in SQL Server\n d) None of the above"); QAns.Add("a");
        Question.Add("Identify the default order of Order by Clause?\n a) Descending\n b) Ascending\n c) Random\n d) None of the above"); QAns.Add("b");
        Question.Add("Interpret if it is possible to have both Orders (i.e. ASC/DES\n c) in a single query?\n a) True\n b) False"); QAns.Add("a");
        Question.Add("ExecuteIf emp_id contain the following set {9, 7, 6, 4, 3, 1, 2}, what will be the output on execution of the following MySQL command?SELECT emp_idFROM personORDER BY emp_id ASC;\n a){9, 7, 6, 4, 3, 1, 2}\n b) {1, 2, 3, 4, 6, 7, 9}\n c) {2, 1, 3, 4, 6, 7, 9}\n d) None of the mentioned"); QAns.Add("b");
        Question.Add("Interpret the meaning of “GROUP BY” clause in Mysql?\n a) Group data by column values\n b) Group data by row values\n c) Group data by column and row values\n d) None of the mentioned"); QAns.Add("a");
        Question.Add("State the meaning of “HAVING” clause in Mysql?\n a) To filter out the row values\n b) To filter out the column values\n c) To filter out the row and column values\n d) None of the mentioned"); QAns.Add("a");
        Question.Add("Classify which of the following belongs to an “aggregate function”?\n a) COUNT\n b) SUM/AVG\n c) MIN/MAX\n d) All of the mentioned"); QAns.Add("d");
        Question.Add("State the significance of the statement “GROUP BY d.name” in the following MySQL statement?SELECT d.name, COUNT (emp_id) emp_noFROM department d INNER JOIN Employee e ON d.dept_id=e.emp_idGROUP BY \n d.name\n a) Aggregation of the field “name” of both table\n b) Aggregation of the field “name” of table “department”\n c) Sorting of the field “name”\n d) None of the mentioned"); QAns.Add("b");
        Question.Add("Where filters data before grouping and Having filters data after grouping\n a) True\n b) False"); QAns.Add("b");
        Question.Add("State whether Null values in GROUP BY fields are omitted.\n a) True\n b) False"); QAns.Add("b");
        Question.Add("Define view?\n a) A view is a special stored procedure executed when certain event occurs\n b) A view is a virtual table which results of executing a pre-compiled query\n c) A view is a database diagram\n d) None of the Mentioned"); QAns.Add("b");
        Question.Add("Identify the command  delete a view \n a) DROP VIEW\n b) DELETE VIEW\n c) REMOVE VIEW\n d) TRUNCATE VIEW"); QAns.Add("a");
        Question.Add("State which of the following statement is true?\n a) Views could be looked as an additional layer on the table which enables us to protect intricate or sensitive data based upon our needs\n b) Views are virtual tables that are compiled at run time\n c) Creating views can improve query response time\n d) All of the Mentioned"); QAns.Add("d");
        Question.Add("State how many types of views a SQL Server has \n a) one\n b) two\n c) three\n d) four"); QAns.Add("b");
        Question.Add("Identify the syntax for creating views \n a) CREATE VIEW AS SELECT\n b) CREATE VIEW AS UPDATE\n c) DROP VIEW AS SELECT\n d) CREATE VIEW AS UPDATE"); QAns.Add("a");
        Question.Add("Identify which of the following is not a class of constraint in MySQL Server.\n a) NOT NULL\n b) CHECK\n c) NULL\n d) UNIQUE"); QAns.Add("c");
        Question.Add("Select the correct statement.\n a) CHECK constraints enforce domain integrity\n b) UNIQUE constraints enforce the uniqueness of the values in a set of columns\n c) In a UNIQUE constraint, no two rows in the table can have the same value for the columns\n d) All of the mentioned"); QAns.Add("d");
        Question.Add("Select which of the following constraint does not enforce uniqueness.\n a) UNIQUE\n b) Primary key\n c) Foreign key\n d) None of the mentioned"); QAns.Add("c");
        Question.Add("Identify which of the given set of SQL statements either executes successfully or have no effect at all.\n a) joins\n b) transactions\n c) filters\n d) deletions"); QAns.Add("b");
        Question.Add("State the process after the transactions are executed successfully?\n a) delete\n b) rollback\n c) commit\n d) update"); QAns.Add("c");
        Question.Add("State what ‘C’ stand for in the ACID property of transactions?\n a) Compound\n b) Concrete\n c) Collision\n d) Consistency"); QAns.Add("d");
        Question.Add("State the isolation property of transactions?\n a) statements form a logic unit\n b) database remains consistent\n c) one transaction does not affect the other\n d) transaction effects are recorded permanently");QAns.Add("c");
        Question.Add("State whether true or falseTransactional processing provides strong guarantees about the outcome of operations.\n a) True\n b) False"); QAns.Add("a");
        Question.Add("State the isolation property of transactions?\n a) statements form a logic unit\n b) database remains consistent\n c) one transaction does not affect the other\n d) transaction effects are recorded permanently"); QAns.Add("c");
        Question.Add("State which of the constraint can be enforced one per table?\n a) Primary key constraint\n b) Not Null constraint\n c) Foreign Key constraint\n d) Check constraint"); QAns.Add("a");
        Question.Add("State true or false: We can use Subqueries inside the from clause\n a) True\n b) False"); QAns.Add("a");
        Question.Add("Identify which of the following is not a built in aggregate function in MySQL?\n a) avg\n b) max\n c) total\n d) count"); QAns.Add("c");
        Question.Add("Execute SELECT branch_name, COUNT (DISTINCT customer_name) FROM depositor, account WHERE depositor.account_number = account.account_number GROUP BY branch_id\n a) The query is syntactically correct but gives the wrong answer\n b) The query is syntactically wrong\n c) The query is syntactically correct and gives the correct answer\n d) The query contains one or more wrongly named clauses."); QAns.Add("b");
        Question.Add("Use the aggregate function to a group of sets of tuples using the ___ clause.\n a) group by\n b) group\n c) group set\n d) group attribute"); QAns.Add("a");
        Question.Add("Identify the  aggregation operation that adds up all the values of the attribute\n a) add\n b) avg\n c) max\n d) sum"); QAns.Add("d");
        for (int j = 0; j < Question.Count; j++)
        {
            QNo.Add(j);
        }
        
    }

    void Update()
    {
        
    }
}
