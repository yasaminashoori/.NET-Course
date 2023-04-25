Insert into tblStudent values (930123485,N'مهیلا',N'جاویدان',N'سید علی',
'123-3456-9',1234,9163331234,'آبادان بوارده شمالی'
)

Insert Into tblStudent Values (93181023,N'محمد رضا',N'ناصری',N'امین',
'127-98745-5',852741,9165412213,N'آبادان خیابان امام خمینی'),
(930147896,N'کبری',N'احمدی',N'صادق','021-885230-7',235,9301203654,
N'اندیمشک خیابان شهدا')

Set Identity_insert tblStudent On
insert into tblStudent (ID, StudentCode, Name, Family, FatherName, NationalID, IDCod, Phone, Address )
values (10,930145897,N'شیما',N'تقی نژاد',N'محمد',
'052-995810-1',9822,9165239500,N'اهواز زیتون کارمندی')
Set identity_insert tblStudent off