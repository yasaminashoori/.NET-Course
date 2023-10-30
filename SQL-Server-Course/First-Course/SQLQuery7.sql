Select * from tblMaster Where Certificate = N'دکتری'

Select * from tblMaster Where Name Like N'محمد%'

Select * from tblMaster Where NationalID Like '4%'

Select * from tblMaster Where NationalID Like '%4'

Select * from tblMaster Where NationalID Like '__5%'

Select * from tblMaster Where IDCode Like '_____'

Select * from tblMaster Where IDCode > 23397

Select * from tblMaster Where ID Between 1 and 4

Select * from tblMaster Where Address Like N'تهران%' or Certificate = N'کارشناسی ارشد'

Select * from tblMaster Where Address Like N'تهران%' or Name Like N'محمد%'

Select * from tblMaster Where Not Certificate = N'دکتری'

Select * from tblMaster Where ID=1 or ID =3

Select * from tblMaster Where ID in(1, 2, 5)

Select * from tblSection Where ClassNum is null

Select * from tblSection Where ClassNum is not null