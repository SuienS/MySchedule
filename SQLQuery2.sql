create procedure events_Insert
(
	@id int output,
	@user_id int,
	@Name varchar(50),
	@Description varchar(max),
	@Type varchar(50),
	@Start_time datetime,
	@End_time datetime,
	@Contacts varchar(max),
	@Location varchar(50),
	@Color_code varchar(50),
	@Reminder varchar(10)
) 
as
	insert into Event(user_id,Name,Description,Type,Start_time,End_time,Contacts,Location,Color_code,Reminder)
	values(@user_id,@Name,@Description,@Type,@Start_time,@End_time,@Contacts,@Location,@Color_code,@Reminder)
	set @id = SCOPE_IDENTITY()