Select * from tblMaster Where Field = N'مهندسی نرم افزار'

Select * from tblMaster Where Field = N'مهندسی شیمی'

Select * from tblMaster Where Field Like N'%شیمی%'

Select * from tblMaster Where NationalID Like '0%'

Select * from tblMaster Where NationalID Like '%5'

Select * from tblMaster Where NationalID Like '__5%'

Select * from tblMaster Where NationalID Like '_5%'

Select * from tblMaster Where IDCode Like '___'

Select * from tblMaster Where ID > 3

Select * from tblMaster Where ID Between 5 and 10

Select * from tblMaster Where Address Like N'خرمشهر%' or field= N'حسابداری'

Select * from tblMaster where Address like N'آبادان%' And field like N'%شیمی%'

Select * from tblMaster where Not Certificate =N'کارشناسی ارشد'

Select * from tblMaster where id =1 or id =7 or id =10

Select * from tblMaster Where Id in(1,7,10)

Select * from tblSection where ClassNum is null

Select * from tblSection where ClassNum is not null
