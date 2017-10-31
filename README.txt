2015-10-19
川沼作成

LEAF実験WITH森先生用に新たにCAR_IDを追加


2017-04-19
齊藤作成

ECOLOG DBにアクセスする際のconnectionStringについて以下のように変更

（変更前）
 String connectionString = "Data Source=ECOLOGDB;Initial Catalog=ECOLOGDBver2;Integrated Security=True;Connection Timeout=60";

（変更後）
 String connectionString = "Data Source=ECOLOGDB2016;Initial Catalog=ECOLOGDBver3;Integrated Security=True;Connection Timeout=60";
 
 
 2017-07-18
 齊藤作成
 
 インサート先のテーブルをLEAFSPY_RAWからLEAFSPY_RAW2に変更
 TRIP_IDを参照する際の参照先をTRIPS_LINKS_LOOKUPからTRIPS_LINKS_LOOKUP2に変更