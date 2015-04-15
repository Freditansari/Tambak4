import MySQLdb
import time,datetime
import string
import os
import sys
import adodbapi

startd = time.time()

connection = adodbapi.connect(r'Provider=SQLOLEDB;Data Source=192.168.1.249, 8888;Initial Catalog=CPL;User ID=WIN-T3JLD54E800\leonard; Password=leo4321;Integrated Security=SSPI')
cursorprod = connection.cursor()
#connection.autocommit(True)
connection2 = adodbapi.connect(r'Provider=SQLOLEDB;Data Source=WIN-T3JLD54E800\SQLEXPRESS;Initial Catalog=CPL;User ID=WIN-T3JLD54E800\leonard; Password=leo4321;Integrated Security=SSPI')
cursordev = connection2.cursor()
#connection2.autocommit(True)

tablelist=["Contacts","Ponds","PondsProductionCycles","FeedingLogs","SamplingLogs","WaterParameterLogs","PDOControl"]
dblist=["CPL","Hasfarm","KotaAgung"]

for dbname in dblist:
    cursorprod.execute("USE [%s]"%dbname)
    cursordev.execute("USE [%s]"%dbname)
    cursordev.execute('EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"')
    
    for tn in tablelist:
        cursorprod.execute("select * from Information_schema.Columns where table_name='%s'"%tn)
        tablecols=[list(row) for row in cursorprod.fetchall()]
        cursordev.execute("select * from Information_schema.Columns where table_name='%s'"%tn)
        tablecols2=[list(row) for row in cursordev.fetchall()]
        for row in tablecols:
            row[0]=tablecols2[0][0]
        tableequals=True
        for row in tablecols:
            if row not in tablecols2:
                tableequals=False
                print "Not in dev: %s"%row
        for row in tablecols2:
            if row not in tablecols:
                tableequals=False
                print "Not in prod: %s"%row
        
        if tableequals==True:
            print "Dev and Prod table Similar for %s %s"%(dbname,tn)
            collist=[]
            coltype=[]
            for row in tablecols2:
                collist.append("%s"%row[3])
                coltype.append("%s"%row[7])
            colstring=','.join(collist)
            
            cursorprod.execute('Select * from %s'%tn)
            dataprod=[list(row) for row in cursorprod.fetchall()]
            cursordev.execute('SET IDENTITY_INSERT %s ON'%tn)
            #cursordev.execute("ALTER TABLE %s NOCHECK CONSTRAINT ALL"%tn)
            
            cursordev.execute('delete from %s'%tn)
            
            for row in dataprod:
                inslist=[]
                for i,rowx in enumerate(row):
                    if rowx==None:
                        inslist.append("Null")
                    elif "int" in coltype[i].lower():
                        inslist.append("%s"%(rowx))
                    elif "float" in coltype[i].lower():
                        inslist.append("%s"%(rowx))
                    elif "bit" in coltype[i].lower():
                        inslist.append("%s"%(rowx))
                    elif "real" in coltype[i].lower():
                        inslist.append("%s"%(rowx))
                    elif "varchar" in coltype[i].lower():
                        inslist.append("'%s'"%(rowx))
                    elif "ntext" in coltype[i].lower():
                        inslist.append("'%s'"%(rowx))
                    elif "datetime" in coltype[i].lower():
                        #if 
                        inslist.append("'%s'"%(rowx))
                    else:
                        raw_input("Found new column type %s %s"%(coltype[i],rowx))
                        inslist.append("'%s'"%(rowx))
                
                command="insert into %s (%s) values (%s)"%(tn,colstring,','.join(inslist))
                #print (command)
                cursordev.execute(command)
            cursordev.execute('SET IDENTITY_INSERT %s OFF'%tn)
            #connection2.commit()
    
    
    cursordev.execute('EXEC sp_msforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL"')
connection2.commit()
print "Elapsed = %s s"%(time.time() - startd)
