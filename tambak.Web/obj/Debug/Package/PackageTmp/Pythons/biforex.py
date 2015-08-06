import time,datetime
import string
import os
import sys
import adodbapi
import urllib2

connection = adodbapi.connect(r'Provider=SQLOLEDB;Data Source=WIN-T3JLD54E800\SQLEXPRESS;Initial Catalog=CPL;User ID=WIN-T3JLD54E800\leonard; Password=leo4321;Integrated Security=SSPI')
cursor = connection.cursor()

req = urllib2.Request("http://www.bi.go.id/id/moneter/informasi-kurs/transaksi-bi/Default.aspx", headers={'User-Agent' : "Magic Browser"}) 
con = urllib2.urlopen(req)
datax = con.read()

datar=datax[:]
currency="AUD,BND,CAD,CHF,CNY,DKK,EUR,GBP,HKD,JPY,KRW,KWD,MYR,NOK,NZD,PHP,SAR,SEK,SGD,THB,USD".split(",")

result=[]
for cur in currency:
    data=datar[:]
    cuttop=data.split("<td>%s"%cur)[1]
    data=cuttop[:500].split("</td>")
    unit=data[1].split(">")[-1]
    jual=float(data[2].split(">")[-1].replace(",",""))
    beli=float(data[3].split(">")[-1].replace(",",""))
    result.append([cur,jual,beli,(jual+beli)/2])
    
    command=("insert into CurrencyRate (CurrencyShortCode,SellRate,PurchaseRate,MiddleRate) values ('%s',%s,%s,%s)"%(cur,jual,beli,(jual+beli)/2))
    print command
    cursor.execute(command)
    connection.commit()
    
#print body

