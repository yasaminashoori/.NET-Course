Update tblStudent set Address =N'کرج' where id = 1

Update tblStudent set Address =N'کرمانشاه' where Address =N'یزد'

Update tblStudent set Address =N'کرمانشاه', IDCode = 1234
 where Address =N'یزد'

Delete From tblLesson Where Field= N'مهندسی'

Delete From tblLesson Where Field= N'مهندسی' and ID not 
in(Select LessonID from tblSection )