import MySQLdb
import time,datetime
import string
import os
import sys
import adodbapi

startd = time.time()

connection = adodbapi.connect(r'Provider=SQLOLEDB;Data Source=192.168.1.249, 8888;Initial Catalog=CPL;User ID=WIN-T3JLD54E800\leonard; Password=leo4321;Integrated Security=SSPI')
cursor = connection.cursor()
#connection.autocommit(True)
connection2 = adodbapi.connect(r'Provider=SQLOLEDB;Data Source=WIN-T3JLD54E800\SQLEXPRESS;Initial Catalog=CPL;User ID=WIN-T3JLD54E800\leonard; Password=leo4321;Integrated Security=SSPI')
cursor2 = connection2.cursor()
#connection2.autocommit(True)

cursor2.execute("select table_name from Information_schema.Tables")
tablelist=[row[0] for row in cursor2.fetchall()]
dblist=["CPL","Hasfarm","KotaAgung"]

for dbname in dblist:
    cursor.execute("USE [%s]"%dbname)

    for tn in tablelist:
        cursor.execute("select * from Information_schema.Columns where table_name='%s'"%tn)
        tables=[list(row) for row in cursor.fetchall()]
        ##for row in tables:print row
        
        cursor2.execute("select * from Information_schema.Columns where table_name='%s'"%tn)
        tables2=[list(row) for row in cursor2.fetchall()]
        ##for row in tables2:print row
        for row in tables:
            row[0]=tables2[0][0]

        ##print tables
        ##print tables2

        for row in tables:
            if row not in tables2:
                print "Not in dev: %s"%row
        for row in tables2:
            if row not in tables:
                print "Not in prod: %s"%row

##cursor.execute("select * from Information_schema.Columns where table_catalog='CPL' and table_name = 'PurchaseTaxTransactions'")
##data=[list(row) for row in cursor.fetchall()]
##for row in data:print row


##cursor.execute('Select * from PondsProductionCycles')
##data=[list(row) for row in cursor.fetchall()]
##
##for row in data:
##    command='insert into PondsProductionCycles values (%s)'%row
##    #print command.replace("[","").replace("]","")
##    cursor2.execute(command.replace("[","").replace("]",""))

print "Elapsed = %s s"%(time.time() - startd)
