--Insert into tblStudent Values (9305468630,N'سهیلا',N'کریمی',N'امیر', '123-5678-9',
--1234,134576856,N'تهران پیروزی نبرد' 
--)

--Insert into tblStudent Values (6466767,N'محمدحسین',N'عابدی',N'امین', '123-3456-6', 
--5456567, 0932545657,N'بوشهر، میدان امام'),
--(9302345034,N'فاطمه',N'اکبری',N'پارسا', '021-4567-3', 453, 09435565634,N'تهران، گوته')

Set Identity_insert tblStudent On 
insert into tblStudent (ID, StudentCode, Name, Family, FatherName, NationalID, IDCode, Phone, Address)
values (10, 345555,N'محمد',N'آقایی احمدی',N'سعید', 
'032-4456-5', 87857, 093245456,N'تهران، ونک')
set identity_insert tblStudent off