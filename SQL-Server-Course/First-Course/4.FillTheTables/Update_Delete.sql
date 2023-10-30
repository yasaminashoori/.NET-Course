Update tblStudent set Address =N'آبادان' where id = 1

Update tblMaster Set Field =N'مهندسی شیمی' where Field =N'شیمی'

Update tblLesson Set Title =N'الکترونیک' , UnitNum =3 
Where Title =N'معماری کامپیوتری'

Delete From tblLesson where Field = N'مهندسی سخت افزار'

Delete From tblLesson where Field =N'شیمی' and ID not 
in(Select lessonID from tblSection  )