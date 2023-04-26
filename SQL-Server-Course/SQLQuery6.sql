
--Select * from  tblStudent 

Select StudentCode, Name, Family from tblStudent

Select Name, Family, StudentCode from tblStudent

Select ID, StudentCode, Name + ' ' + Family As FullName, FatherName, NationalID, IDCode, Phone, Address
from tblStudent