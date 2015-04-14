import MySQLdb
import time,datetime
import string
import os
import sys
import adodbapi

startd = time.time()

connection = adodbapi.connect(r'Provider=SQLOLEDB;Data Source=WIN-T3JLD54E800\SQLEXPRESS;Initial Catalog=CPL;User ID=WIN-T3JLD54E800\leonard; Password=leo4321;Integrated Security=SSPI')
cursor = connection.cursor()
#connection.autocommit(True)

cursor.execute('Select ProductionCycleID,LogDate,FeedGiven from FeedingLogs order by ProductionCycleID,logdate')
data=[list([row[0],row[1].strftime("%Y%m%d"),row[2]]) for row in cursor.fetchall()]
#print data
result=[]
start=True
for row in data:
    if start==True:
        result.append([row[0],row[1],row[2]])
        start=False
    elif row[0]==result[-1][0] and row[1]==result[-1][1]:
        result[-1][2]=result[-1][2]+row[2]
    else:
        result.append([row[0],row[1],row[2]])
cursor.execute("delete from DailyFeedSummary")
for row in result:
    command=("insert into DailyFeedSummary (ProductionCycleID,Date,Feed) values (%s,'%s',%s)"%(row[0],row[1],row[2]))
    print command
    cursor.execute(command)

cursor.execute('Select ProductionCycleID,Date,Feed from DailyFeedSummary order by ProductionCycleID,Date desc')
data2=[list([row[0],row[1],row[2]]) for row in cursor.fetchall()]
print data2
cursor.execute("delete from AverageDailyFeedSummary")
result2=[]
start=True
for row in data2:
    if start==True:
        result2.append([row[0],row[2],1])
        start=False
    elif row[0]==result2[-1][0] and result2[-1][2]<7:
        result2[-1][1]=result2[-1][1]+row[2]
        result2[-1][2]=result2[-1][2]+1
    elif row[0]!=result2[-1][0]:
        result2.append([row[0],row[2],1])
    else:
        pass
for row in result2:
    row[1]=float(row[1])/float(row[2])
for row in result2:
    command=("insert into AverageDailyFeedSummary (ProductionCycleID,Average) values (%s,%s)"%(row[0],row[1]))
    print command
    cursor.execute(command)


connection.commit()


print "Elapsed = %s s"%(time.time() - startd)
