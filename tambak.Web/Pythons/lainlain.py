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

cursor.execute('Select MBW,FR from FeedingGuide')
data=[list(row) for row in cursor.fetchall()]

cursor.execute('delete from FRGuide')
for i in range(200,2200):
    mbw=float(i)/100.0
    fr=0.0
    for row in data:
        fr=row[1]
        if row[0]>mbw: break
    command=("insert into FRGuide (MBW,FR) values (%s,%s)"%(mbw,fr))
    print command
    cursor.execute(command)
    

connection.commit()


print "Elapsed = %s s"%(time.time() - startd)
