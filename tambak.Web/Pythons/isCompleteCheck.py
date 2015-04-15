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

cursor.execute('Select POID from PurchaseOrders where isComplete<>1')
podata=[row[0] for row in cursor.fetchall()]

for poid in podata:
    cursor.execute("Select PODetailsID,qty from PODetails where POID='%s'"%poid)
    poddata=cursor.fetchall()
    iscomplete=True
    for pod in poddata:
        cursor.execute("Select sum(qtyReceived) from PODeliveredQuantity where PODetailsID='%s' group by PODetailsID"%pod[0])
        delivered=cursor.fetchall()
        print delivered
        try:
            if delivered[0][0]<=float(pod[1])-0.01:
                iscomplete=False
        except: iscomplete=False
    if iscomplete==True:
        cursor.execute("Update PurchaseOrders set isComplete=1 where POID='%s'"%poid)
        print "%s is complete"%poid

connection.commit()


print "Elapsed = %s s"%(time.time() - startd)
