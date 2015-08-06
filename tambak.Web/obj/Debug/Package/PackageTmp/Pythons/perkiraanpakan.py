import MySQLdb
import time,datetime
import string
import os
import sys
import adodbapi

start = time.time()

if len(sys.argv)>1:dbnames=[sys.argv[1]]
else:dbnames=["CPL","Hasfarm","KotaAgung","Staging"]


for dbn in dbnames:

    connection = adodbapi.connect(r'Provider=SQLOLEDB;Data Source=WIN-T3JLD54E800\SQLEXPRESS;Initial Catalog=%s;User ID=WIN-T3JLD54E800\leonard; Password=leo4321;Integrated Security=SSPI'%dbn)
    cursor = connection.cursor()
    #connection.autocommit(True)
    
    cursor.execute('Select * from FeedingGuide order by doc asc')
    guide=[list([row[0],row[1],float(row[2]),float(row[3]),float(row[4]),float(row[5]),float(row[6]),float(row[7])]) for row in cursor.fetchall()]
    
    cursor.execute('Select ProductionCycleID,StartDate,NumberOfFry from PondsProductionCycles where isInProduction=1')
    ponds=[[row[0],row[1],row[2],0,0.0,0,0] for row in cursor.fetchall()]
    
    cursor.execute('Select ProductionCycleID,Age,MedianBodyWeight,Populations from SamplingLogs')
    sampling=cursor.fetchall()
    cursor.execute('delete from feedingplan')
    for samp in sampling:
        for pond in ponds:
            if samp[0]==pond[0] and samp[1]>pond[3]:
                pond[3]=samp[1]
                pond[4]=samp[2]
                pond[5]=int(samp[3])
    for pond in ponds:
        try:
            pond[6]=(datetime.datetime.now().date()-pond[1]).days
            pond[6]=pond[6]+1
        except:
            try:
                pond[6]=(datetime.datetime.now().date()-pond[1].date()).days
                pond[6]=pond[6]+1
            except:
                pass
    # 0     1      2    3        4      5        6
    #id,startdate,pop,sampage,sampmbw,samppop,sampage
    #for row in ponds: print row
    for pond in ponds:
        if pond[1]!=None:
            if pond[3]>0 and pond[4]>0.0:
                if pond[4]+0.22*(pond[6]-pond[3])<=20.56:
                    cmbw=pond[4]
                    cage=pond[6]
                    print pond
                    while cmbw<=20.56-0.22:
                        cdate=datetime.datetime.combine(pond[1], datetime.datetime.min.time())+datetime.timedelta(cage-1)
                        cmbw=pond[4]+0.22*(cage-pond[3])
                        pop=pond[5]-pond[5]*0.0025*(cage-pond[3])
                        
                        for g,guid in enumerate(guide):
                            if guid[2]>=cmbw:
                                partial=(cmbw-guide[g-1][2])/(guide[g][2]-guide[g-1][2])
                                meth1=pop*cmbw*(partial*guide[g][3]+(1-partial)*guide[g-1][3])/100000.0
                                meth2=(partial*guide[g][4]+(1-partial)*guide[g-1][4])*pop/100000.0
                                meth3=(partial*guide[g][5]+(1-partial)*guide[g-1][5])*pop/100000.0
                                meth4=(partial*guide[g][6]+(1-partial)*guide[g-1][6])*pop/100000.0
                                meth5=(partial*guide[g][7]+(1-partial)*guide[g-1][7])*pop/100000.0
                                if partial>0.5: pakan=guide[g][1]
                                else: pakan=guide[g-1][1]
                                break
                        
                        
                        if " + " not in pakan:
                            cursor.execute("insert into FeedingPlan (ProductionCycleID,Age,Date,MBW,Population,UsingFR,Using01M,Using05M,Using20M,Using30M,NoPakan,UsingMax) values (%s,%s,'%s',%s,%s,%s,%s,%s,%s,%s,'%s',%s)"%(pond[0],cage,cdate.strftime("%Y%m%d"),cmbw,int(pop),meth1,meth2,meth3,meth4,meth5,pakan,max(meth1,meth2,meth3,meth4,meth5)))
                        else:
                            meth1=meth1/2.0
                            meth2=meth2/2.0
                            meth3=meth3/2.0
                            meth4=meth4/2.0
                            meth5=meth5/2.0
                            cursor.execute("insert into FeedingPlan (ProductionCycleID,Age,Date,MBW,Population,UsingFR,Using01M,Using05M,Using20M,Using30M,NoPakan,UsingMax) values (%s,%s,'%s',%s,%s,%s,%s,%s,%s,%s,'%s',%s)"%(pond[0],cage,cdate.strftime("%Y%m%d"),cmbw,int(pop),meth1,meth2,meth3,meth4,meth5,pakan.split(" + ")[0],max(meth1,meth2,meth3,meth4,meth5)))
                            cursor.execute("insert into FeedingPlan (ProductionCycleID,Age,Date,MBW,Population,UsingFR,Using01M,Using05M,Using20M,Using30M,NoPakan,UsingMax) values (%s,%s,'%s',%s,%s,%s,%s,%s,%s,%s,'%s',%s)"%(pond[0],cage,cdate.strftime("%Y%m%d"),cmbw,int(pop),meth1,meth2,meth3,meth4,meth5,pakan.split(" + ")[1],max(meth1,meth2,meth3,meth4,meth5)))
                            print pond[0],cage,cdate.strftime("%Y%m%d"),pakan
                        
                        cage+=1
            elif pond[6]<120 and pond[6]>0:
                cage=pond[6]
                while cage<=120:
                    cdate=datetime.datetime.combine(pond[1], datetime.datetime.min.time())+datetime.timedelta(cage-1)
                    mbw=guide[cage-1][2]
                    pop=pond[2]-pond[2]*0.0025*(cage)
                    meth1=pop*mbw*guide[cage-1][3]/100000.0
                    meth2=guide[cage-1][4]*pop/100000.0
                    meth3=guide[cage-1][5]*pop/100000.0
                    meth4=guide[cage-1][6]*pop/100000.0
                    meth5=guide[cage-1][7]*pop/100000.0
                    
                    if " + " not in guide[cage-1][1]:
                        cursor.execute("insert into FeedingPlan (ProductionCycleID,Age,Date,MBW,Population,UsingFR,Using01M,Using05M,Using20M,Using30M,NoPakan,UsingMax) values (%s,%s,'%s',%s,%s,%s,%s,%s,%s,%s,'%s',%s)"%(pond[0],cage,cdate.strftime("%Y%m%d"),mbw,int(pop),meth1,meth2,meth3,meth4,meth5,guide[cage-1][1],max(meth1,meth2,meth3,meth4,meth5)))
                    else:
                        meth1=meth1/2.0
                        meth2=meth2/2.0
                        meth3=meth3/2.0
                        meth4=meth4/2.0
                        meth5=meth5/2.0
                        cursor.execute("insert into FeedingPlan (ProductionCycleID,Age,Date,MBW,Population,UsingFR,Using01M,Using05M,Using20M,Using30M,NoPakan,UsingMax) values (%s,%s,'%s',%s,%s,%s,%s,%s,%s,%s,'%s',%s)"%(pond[0],cage,cdate.strftime("%Y%m%d"),mbw,int(pop),meth1,meth2,meth3,meth4,meth5,guide[cage-1][1].split(" + ")[0],max(meth1,meth2,meth3,meth4,meth5)))
                        cursor.execute("insert into FeedingPlan (ProductionCycleID,Age,Date,MBW,Population,UsingFR,Using01M,Using05M,Using20M,Using30M,NoPakan,UsingMax) values (%s,%s,'%s',%s,%s,%s,%s,%s,%s,%s,'%s',%s)"%(pond[0],cage,cdate.strftime("%Y%m%d"),mbw,int(pop),meth1,meth2,meth3,meth4,meth5,guide[cage-1][1].split(" + ")[1],max(meth1,meth2,meth3,meth4,meth5)))
                        print pond[0],cage,cdate.strftime("%Y%m%d"),guide[cage-1][1]
                    
                    cage+=1
    
    connection.commit()


print "Elapsed = %s s"%(time.time() - start)
