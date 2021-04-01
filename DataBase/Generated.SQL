/*
Created: 08.06.2019
Modified: 09.06.2019
Project: Поликлиника
Model: PostgreSQL 10
Company: 9ИВТ-61
Author: Ламов
Version: 1
Database: PostgreSQL 10
*/


-- Create tables section -------------------------------------------------

-- Table Medical_institution

CREATE TABLE "Medical_institution"(
 "ID_institution" Integer NOT NULL,
 "Naim" Character(256),
 "INN_KPP" Character(22) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Medical_institution" IS 'Лечебное учреждение'
;
COMMENT ON COLUMN "Medical_institution"."ID_institution" IS 'Номер учреждения'
;
COMMENT ON COLUMN "Medical_institution"."Naim" IS 'Наименование'
;
COMMENT ON COLUMN "Medical_institution"."INN_KPP" IS 'ИНН/КПП организации'
;

-- Add keys for table Medical_institution

ALTER TABLE "Medical_institution" ADD CONSTRAINT "Key1" PRIMARY KEY ("ID_institution","INN_KPP")
;

ALTER TABLE "Medical_institution" ADD CONSTRAINT "Номер учреждения" UNIQUE ("ID_institution")
;

-- Table Hospital_buildings

CREATE TABLE "Hospital_buildings"(
 "Institution_building_number" Integer NOT NULL,
 "ID_institution" Integer NOT NULL,
 "INN_KPP" Character(22) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Hospital_buildings" IS 'Корпусы лечебного учреждения'
;
COMMENT ON COLUMN "Hospital_buildings"."Institution_building_number" IS 'Номер корпуса учреждения'
;
COMMENT ON COLUMN "Hospital_buildings"."ID_institution" IS 'Номер учреждения'
;
COMMENT ON COLUMN "Hospital_buildings"."INN_KPP" IS 'ИНН/КПП организации'
;

-- Add keys for table Hospital_buildings

ALTER TABLE "Hospital_buildings" ADD CONSTRAINT "Key2" PRIMARY KEY ("Institution_building_number","ID_institution","INN_KPP")
;

ALTER TABLE "Hospital_buildings" ADD CONSTRAINT "Номер корпуса учреждения" UNIQUE ("Institution_building_number")
;

-- Table Individuals

CREATE TABLE "Individuals"(
 "INN" Character(12) NOT NULL,
 "Family" Character(256) NOT NULL,
 "Name" Character(256) NOT NULL,
 "Last_Name" Character(256) NOT NULL,
 "gen" Text,
 "DOB" Date,
 "bpl" Character(256),
 "Insurance_policy" Character(12) NOT NULL,
 "Phones" Character(256),
 "email" Character(256),
 "Job_Number" Integer NOT NULL,
 "INN_KPP" Character(22) NOT NULL,
 "ID_adress" Integer NOT NULL,
 "ID_Street" Integer,
 "ID_house" Integer
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Individuals" IS 'Физические лица'
;
COMMENT ON COLUMN "Individuals"."INN" IS 'ИНН физического лица'
;
COMMENT ON COLUMN "Individuals"."Family" IS 'Фамилия'
;
COMMENT ON COLUMN "Individuals"."Name" IS 'Имя'
;
COMMENT ON COLUMN "Individuals"."Last_Name" IS 'Отчество'
;
COMMENT ON COLUMN "Individuals"."gen" IS 'Пол'
;
COMMENT ON COLUMN "Individuals"."DOB" IS 'Дата рождения'
;
COMMENT ON COLUMN "Individuals"."bpl" IS 'Место рождения'
;
COMMENT ON COLUMN "Individuals"."Insurance_policy" IS 'Страховой полис'
;
COMMENT ON COLUMN "Individuals"."Phones" IS 'Телефоны'
;
COMMENT ON COLUMN "Individuals"."email" IS 'Электронная почта'
;
COMMENT ON COLUMN "Individuals"."Job_Number" IS 'Номер должности'
;
COMMENT ON COLUMN "Individuals"."INN_KPP" IS 'ИНН/КПП организации'
;
COMMENT ON COLUMN "Individuals"."ID_adress" IS 'Код адреса'
;
COMMENT ON COLUMN "Individuals"."ID_Street" IS 'Номер улицы'
;
COMMENT ON COLUMN "Individuals"."ID_house" IS 'ID_house'
;

-- Create indexes for table Individuals

CREATE INDEX "IX_address" ON "Individuals" ("ID_adress","ID_Street","ID_house")
;

CREATE INDEX "IX_Profession" ON "Individuals" ("Job_Number")
;

CREATE INDEX "IX_job" ON "Individuals" ("INN_KPP")
;

-- Add keys for table Individuals

ALTER TABLE "Individuals" ADD CONSTRAINT "Key3" PRIMARY KEY ("INN")
;

ALTER TABLE "Individuals" ADD CONSTRAINT "ИНН физического лица" UNIQUE ("INN")
;

-- Table Doctors

CREATE TABLE "Doctors"(
 "ID_doctor's" Integer NOT NULL,
 "INN" Character(12) NOT NULL,
 "Job_Number" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Doctors" IS 'Врачи'
;
COMMENT ON COLUMN "Doctors"."ID_doctor's" IS 'Номер врача'
;
COMMENT ON COLUMN "Doctors"."INN" IS 'ИНН физического лица'
;
COMMENT ON COLUMN "Doctors"."Job_Number" IS 'Номер должности'
;

-- Create indexes for table Doctors

CREATE INDEX "IX_INN_Doctor" ON "Doctors" ("INN")
;

-- Add keys for table Doctors

ALTER TABLE "Doctors" ADD CONSTRAINT "Key4" PRIMARY KEY ("ID_doctor's","Job_Number")
;

ALTER TABLE "Doctors" ADD CONSTRAINT "Номер врача" UNIQUE ("ID_doctor's")
;

-- Table Doctor's_schedules

CREATE TABLE "Doctor's_schedules"(
 "Number_schedule_doctors" Integer NOT NULL,
 "Date" Date,
 "Time" Time,
 "Institution_building_number" Integer NOT NULL,
 "ID_institution" Integer NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "INN_KPP" Character(22) NOT NULL,
 "Job_Number" Integer NOT NULL,
 "ID cabinet" Integer
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Doctor's_schedules" IS 'Расписания врачей'
;
COMMENT ON COLUMN "Doctor's_schedules"."Number_schedule_doctors" IS 'Номер записи в расписании врачей'
;
COMMENT ON COLUMN "Doctor's_schedules"."Date" IS 'Дата'
;
COMMENT ON COLUMN "Doctor's_schedules"."Time" IS 'Время'
;
COMMENT ON COLUMN "Doctor's_schedules"."Institution_building_number" IS 'Номер корпуса учреждения'
;
COMMENT ON COLUMN "Doctor's_schedules"."ID_institution" IS 'Номер учреждения'
;
COMMENT ON COLUMN "Doctor's_schedules"."ID_doctor's" IS 'Номер врача'
;
COMMENT ON COLUMN "Doctor's_schedules"."INN_KPP" IS 'ИНН/КПП организации'
;
COMMENT ON COLUMN "Doctor's_schedules"."Job_Number" IS 'Номер должности'
;
COMMENT ON COLUMN "Doctor's_schedules"."ID cabinet" IS 'ID кабинета'
;

-- Create indexes for table Doctor's_schedules

CREATE INDEX "IX_Cabinet_number" ON "Doctor's_schedules" ("Institution_building_number" DESC,"ID_institution" DESC,"INN_KPP" DESC,"ID cabinet")
;

-- Add keys for table Doctor's_schedules

ALTER TABLE "Doctor's_schedules" ADD CONSTRAINT "Key5" PRIMARY KEY ("Number_schedule_doctors","ID_doctor's","Job_Number")
;

ALTER TABLE "Doctor's_schedules" ADD CONSTRAINT "Номер записи в расписании врачей" UNIQUE ("Number_schedule_doctors")
;

-- Table Cabinets

CREATE TABLE "Cabinets"(
 "ID cabinet" Integer NOT NULL,
 "Cabinet_Number" Integer NOT NULL,
 "cabinet_name" Character(256),
 "Institution_building_number" Integer NOT NULL,
 "ID_institution" Integer NOT NULL,
 "INN_KPP" Character(22) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Cabinets" IS 'Кабинеты'
;
COMMENT ON COLUMN "Cabinets"."ID cabinet" IS 'ID кабинета'
;
COMMENT ON COLUMN "Cabinets"."Cabinet_Number" IS 'Номер кабинета'
;
COMMENT ON COLUMN "Cabinets"."cabinet_name" IS 'Наименование кабинета'
;
COMMENT ON COLUMN "Cabinets"."Institution_building_number" IS 'Номер корпуса учреждения'
;
COMMENT ON COLUMN "Cabinets"."ID_institution" IS 'Номер учреждения'
;
COMMENT ON COLUMN "Cabinets"."INN_KPP" IS 'ИНН/КПП организации'
;

-- Add keys for table Cabinets

ALTER TABLE "Cabinets" ADD CONSTRAINT "Key6" PRIMARY KEY ("Institution_building_number","ID_institution","INN_KPP","ID cabinet")
;

ALTER TABLE "Cabinets" ADD CONSTRAINT "ID кабинета" UNIQUE ("ID cabinet")
;

-- Table Pre-appointment

CREATE TABLE "Pre-appointment"(
 "Reception_Record_Number" Integer NOT NULL,
 "Number_schedule_doctors" Integer NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "Job_Number" Integer NOT NULL,
 "INN" Character(12) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Pre-appointment" IS 'Предварительная запись приёма'
;
COMMENT ON COLUMN "Pre-appointment"."Reception_Record_Number" IS 'Номер записи приёма'
;
COMMENT ON COLUMN "Pre-appointment"."Number_schedule_doctors" IS 'Номер записи в расписании врачей'
;
COMMENT ON COLUMN "Pre-appointment"."ID_doctor's" IS 'Номер врача'
;
COMMENT ON COLUMN "Pre-appointment"."Job_Number" IS 'Номер должности'
;
COMMENT ON COLUMN "Pre-appointment"."INN" IS 'ИНН физического лица'
;

-- Add keys for table Pre-appointment

ALTER TABLE "Pre-appointment" ADD CONSTRAINT "Key7" PRIMARY KEY ("Reception_Record_Number","Number_schedule_doctors","ID_doctor's","Job_Number","INN")
;

ALTER TABLE "Pre-appointment" ADD CONSTRAINT "Номер записи приёма" UNIQUE ("Reception_Record_Number")
;

-- Table Patient_Records

CREATE TABLE "Patient_Records"(
 "Patient_record_number" Integer NOT NULL,
 "INN" Character(12) NOT NULL,
 "Anamnes" Text,
 "Sick_leave_number" Integer NOT NULL,
 "Number_ treatment_assigned" Integer NOT NULL,
 "Reception_Record_Number" Integer,
 "Number_schedule_doctors" Integer,
 "ID_doctor's" Integer,
 "Job_Number" Integer,
 "ID_diagnos" Character(10) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Patient_Records" IS 'Записи в карточке пациента'
;
COMMENT ON COLUMN "Patient_Records"."Patient_record_number" IS 'Номер записи в карточке пациента'
;
COMMENT ON COLUMN "Patient_Records"."Anamnes" IS 'Анамнез'
;
COMMENT ON COLUMN "Patient_Records"."Sick_leave_number" IS 'Номер больничного листа'
;
COMMENT ON COLUMN "Patient_Records"."Number_ treatment_assigned" IS 'Номер назначенного лечения'
;

-- Create indexes for table Patient_Records

CREATE INDEX "IX_Relationship2" ON "Patient_Records" ("Reception_Record_Number","Number_schedule_doctors","ID_doctor's","Job_Number","INN")
;

CREATE INDEX "IX_Treatment" ON "Patient_Records" ("Number_ treatment_assigned")
;

CREATE INDEX "IX_Hospital_in_card" ON "Patient_Records" ("Sick_leave_number")
;

-- Add keys for table Patient_Records

ALTER TABLE "Patient_Records" ADD CONSTRAINT "Key8" PRIMARY KEY ("Patient_record_number","INN","ID_diagnos")
;

-- Table Plots

CREATE TABLE "Plots"(
 "Plot_number" Integer NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "Job_Number" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Plots" IS 'Участки'
;
COMMENT ON COLUMN "Plots"."Plot_number" IS 'Номер участка'
;
COMMENT ON COLUMN "Plots"."ID_doctor's" IS 'Номер врача'
;
COMMENT ON COLUMN "Plots"."Job_Number" IS 'Номер должности'
;

-- Add keys for table Plots

ALTER TABLE "Plots" ADD CONSTRAINT "Key10" PRIMARY KEY ("Plot_number","ID_doctor's","Job_Number")
;

ALTER TABLE "Plots" ADD CONSTRAINT "Номер участка" UNIQUE ("Plot_number")
;

-- Table Borders_plots

CREATE TABLE "Borders_plots"(
 "Border_number" Integer NOT NULL,
 "Plot_number" Integer NOT NULL,
 "ID_Street" Integer NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "Job_Number" Integer NOT NULL,
 "ID_house" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Borders_plots" IS 'Границы участков'
;
COMMENT ON COLUMN "Borders_plots"."Border_number" IS 'Номер границы участка'
;
COMMENT ON COLUMN "Borders_plots"."Plot_number" IS 'Номер участка'
;
COMMENT ON COLUMN "Borders_plots"."ID_Street" IS 'Номер улицы'
;
COMMENT ON COLUMN "Borders_plots"."ID_doctor's" IS 'Номер врача'
;
COMMENT ON COLUMN "Borders_plots"."Job_Number" IS 'Номер должности'
;
COMMENT ON COLUMN "Borders_plots"."ID_house" IS 'ID_house'
;

-- Add keys for table Borders_plots

ALTER TABLE "Borders_plots" ADD CONSTRAINT "Key11" PRIMARY KEY ("Border_number","Plot_number","ID_Street","ID_doctor's","Job_Number","ID_house")
;

ALTER TABLE "Borders_plots" ADD CONSTRAINT "Номер границы участка" UNIQUE ("Border_number")
;

-- Table Job_Classifier

CREATE TABLE "Job_Classifier"(
 "Job_Number" Integer NOT NULL,
 "Job_title" Character(256) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Job_Classifier" IS 'Классификатор должностей'
;
COMMENT ON COLUMN "Job_Classifier"."Job_Number" IS 'Номер должности'
;
COMMENT ON COLUMN "Job_Classifier"."Job_title" IS 'Наименование должности'
;

-- Add keys for table Job_Classifier

ALTER TABLE "Job_Classifier" ADD CONSTRAINT "Key13" PRIMARY KEY ("Job_Number")
;

ALTER TABLE "Job_Classifier" ADD CONSTRAINT "Номер должности" UNIQUE ("Job_Number")
;

-- Table Diagnosis_Classifier

CREATE TABLE "Diagnosis_Classifier"(
 "ID_diagnos" Character(10) NOT NULL,
 "diagnos_name" Text NOT NULL,
 "ID_Parent" Character(10)
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Diagnosis_Classifier" IS 'Классификатор диагнозов'
;
COMMENT ON COLUMN "Diagnosis_Classifier"."ID_diagnos" IS 'Код диагноза'
;
COMMENT ON COLUMN "Diagnosis_Classifier"."diagnos_name" IS 'Наименование диагноза'
;
COMMENT ON COLUMN "Diagnosis_Classifier"."ID_Parent" IS 'Код родителя'
;

-- Add keys for table Diagnosis_Classifier

ALTER TABLE "Diagnosis_Classifier" ADD CONSTRAINT "Key14" PRIMARY KEY ("ID_diagnos")
;

-- Table Sick_leave

CREATE TABLE "Sick_leave"(
 "Sick_leave_number" Integer NOT NULL,
 "date_leave_number" Date
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Sick_leave" IS 'Больничные листы'
;
COMMENT ON COLUMN "Sick_leave"."Sick_leave_number" IS 'Номер больничного листа'
;
COMMENT ON COLUMN "Sick_leave"."date_leave_number" IS 'Дата создания больничного листа'
;

-- Add keys for table Sick_leave

ALTER TABLE "Sick_leave" ADD CONSTRAINT "Key15" PRIMARY KEY ("Sick_leave_number")
;

ALTER TABLE "Sick_leave" ADD CONSTRAINT "Номер больничного листа" UNIQUE ("Sick_leave_number")
;

-- Table Hospital_records

CREATE TABLE "Hospital_records"(
 "Hospital_record_number" Integer NOT NULL,
 "data_record" Date,
 "record" Text,
 "Sick_leave_number" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Hospital_records" IS 'Записи больничных листов'
;
COMMENT ON COLUMN "Hospital_records"."Hospital_record_number" IS 'Номер записи больничного листа'
;
COMMENT ON COLUMN "Hospital_records"."data_record" IS 'Дата записи'
;
COMMENT ON COLUMN "Hospital_records"."record" IS 'Запись в больничном листе'
;
COMMENT ON COLUMN "Hospital_records"."Sick_leave_number" IS 'Номер больничного листа'
;

-- Add keys for table Hospital_records

ALTER TABLE "Hospital_records" ADD CONSTRAINT "Key16" PRIMARY KEY ("Hospital_record_number","Sick_leave_number")
;

ALTER TABLE "Hospital_records" ADD CONSTRAINT "Номер записи больничного листа" UNIQUE ("Hospital_record_number")
;

-- Table Prescribed_treatment

CREATE TABLE "Prescribed_treatment"(
 "Number_ treatment_assigned" Integer NOT NULL,
 "Treatment_type_number" Integer NOT NULL,
 "Treatment_number" Integer NOT NULL,
 "Reception_method_number" Integer NOT NULL,
 "Dosage_number" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Prescribed_treatment" IS 'Назначенное лечение'
;
COMMENT ON COLUMN "Prescribed_treatment"."Number_ treatment_assigned" IS 'Номер назначенного лечения'
;
COMMENT ON COLUMN "Prescribed_treatment"."Treatment_type_number" IS 'Номер вида лечения'
;
COMMENT ON COLUMN "Prescribed_treatment"."Treatment_number" IS 'Номер метода лечения'
;
COMMENT ON COLUMN "Prescribed_treatment"."Reception_method_number" IS 'Номер способа приёма'
;
COMMENT ON COLUMN "Prescribed_treatment"."Dosage_number" IS 'Номер дозировки'
;

-- Create indexes for table Prescribed_treatment

CREATE INDEX "IX_Treatment_type" ON "Prescribed_treatment" ("Treatment_type_number")
;

CREATE INDEX "IX_Treatment_method" ON "Prescribed_treatment" ("Treatment_number")
;

CREATE INDEX "IX_Reception_methods" ON "Prescribed_treatment" ("Reception_method_number")
;

CREATE INDEX "IX_Doses" ON "Prescribed_treatment" ("Dosage_number")
;

-- Add keys for table Prescribed_treatment

ALTER TABLE "Prescribed_treatment" ADD CONSTRAINT "Key17" PRIMARY KEY ("Number_ treatment_assigned")
;

ALTER TABLE "Prescribed_treatment" ADD CONSTRAINT "Номер назначенного лечения" UNIQUE ("Number_ treatment_assigned")
;

-- Table Treatment_methods

CREATE TABLE "Treatment_methods"(
 "Treatment_number" Integer NOT NULL,
 "Treatment_number_name" Character(256) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Treatment_methods" IS 'Методы лечения'
;
COMMENT ON COLUMN "Treatment_methods"."Treatment_number" IS 'Номер метода лечения'
;
COMMENT ON COLUMN "Treatment_methods"."Treatment_number_name" IS 'Наименование метода лечения'
;

-- Add keys for table Treatment_methods

ALTER TABLE "Treatment_methods" ADD CONSTRAINT "Key18" PRIMARY KEY ("Treatment_number")
;

ALTER TABLE "Treatment_methods" ADD CONSTRAINT "Номер метода лечения" UNIQUE ("Treatment_number")
;

ALTER TABLE "Treatment_methods" ADD CONSTRAINT "Наименование метода лечения" UNIQUE ("Treatment_number_name")
;

-- Table Types_of_treatment

CREATE TABLE "Types_of_treatment"(
 "Treatment_type_number" Integer NOT NULL,
 "Treatment_type_name" Character(256) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Types_of_treatment" IS 'Виды лечения'
;
COMMENT ON COLUMN "Types_of_treatment"."Treatment_type_number" IS 'Номер вида лечения'
;
COMMENT ON COLUMN "Types_of_treatment"."Treatment_type_name" IS 'Наименование вида лечения'
;

-- Add keys for table Types_of_treatment

ALTER TABLE "Types_of_treatment" ADD CONSTRAINT "Key19" PRIMARY KEY ("Treatment_type_number")
;

ALTER TABLE "Types_of_treatment" ADD CONSTRAINT "Номер вида лечения" UNIQUE ("Treatment_type_number")
;

ALTER TABLE "Types_of_treatment" ADD CONSTRAINT "Наименование вида лечения" UNIQUE ("Treatment_type_name")
;

-- Table Reception_methods

CREATE TABLE "Reception_methods"(
 "Reception_method_number" Integer NOT NULL,
 "Reception_method_name" Character(256) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Reception_methods" IS 'Способы приёма'
;
COMMENT ON COLUMN "Reception_methods"."Reception_method_number" IS 'Номер способа приёма'
;
COMMENT ON COLUMN "Reception_methods"."Reception_method_name" IS 'Наименование способа приёма'
;

-- Add keys for table Reception_methods

ALTER TABLE "Reception_methods" ADD CONSTRAINT "Key20" PRIMARY KEY ("Reception_method_number")
;

ALTER TABLE "Reception_methods" ADD CONSTRAINT "Номер способа приёма" UNIQUE ("Reception_method_number")
;

ALTER TABLE "Reception_methods" ADD CONSTRAINT "Наименование способа приёма" UNIQUE ("Reception_method_name")
;

-- Table Dosage

CREATE TABLE "Dosage"(
 "Dosage_number" Integer NOT NULL,
 "dosage_name" Character(256) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Dosage" IS 'Дозировки'
;
COMMENT ON COLUMN "Dosage"."Dosage_number" IS 'Номер дозировки'
;
COMMENT ON COLUMN "Dosage"."dosage_name" IS 'Наименование дозировки'
;

-- Add keys for table Dosage

ALTER TABLE "Dosage" ADD CONSTRAINT "Key21" PRIMARY KEY ("Dosage_number")
;

ALTER TABLE "Dosage" ADD CONSTRAINT "Номер дозировки" UNIQUE ("Dosage_number")
;

ALTER TABLE "Dosage" ADD CONSTRAINT "Наименование дозировки" UNIQUE ("dosage_name")
;

-- Table Diagnoses

CREATE TABLE "Diagnoses"(
)
WITH (
 autovacuum_enabled=true)
;

-- Table Work_places

CREATE TABLE "Work_places"(
 "INN_KPP" Character(22) NOT NULL,
 "Work_name" Character(256),
 "work_phone" Character(256)
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Work_places" IS 'Места работы'
;
COMMENT ON COLUMN "Work_places"."INN_KPP" IS 'ИНН/КПП организации'
;
COMMENT ON COLUMN "Work_places"."Work_name" IS 'Наименование организации'
;
COMMENT ON COLUMN "Work_places"."work_phone" IS 'Рабочий телефон'
;

-- Add keys for table Work_places

ALTER TABLE "Work_places" ADD CONSTRAINT "Key25" PRIMARY KEY ("INN_KPP")
;

ALTER TABLE "Work_places" ADD CONSTRAINT "ИНН/КПП организации" UNIQUE ("INN_KPP")
;

-- Table Adresses

CREATE TABLE "Adresses"(
 "ID_adress" Integer NOT NULL,
 "Country" Character(256) NOT NULL,
 "Region" Character(256) NOT NULL,
 "Locality" Character(256),
 "Sity" Character(256),
 "index" Character(6) NOT NULL,
 "Housing_house" Character(5),
 "porch" Character(3),
 "Apartment_number" Character(5),
 "ID_Street" Integer NOT NULL,
 "ID_house" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Adresses" IS 'Адреса'
;
COMMENT ON COLUMN "Adresses"."ID_adress" IS 'Код адреса'
;
COMMENT ON COLUMN "Adresses"."Country" IS 'Страна'
;
COMMENT ON COLUMN "Adresses"."Region" IS 'Регион'
;
COMMENT ON COLUMN "Adresses"."Locality" IS 'Населенный пункт'
;
COMMENT ON COLUMN "Adresses"."Sity" IS 'Город'
;
COMMENT ON COLUMN "Adresses"."index" IS 'Почтовый индекс'
;
COMMENT ON COLUMN "Adresses"."Housing_house" IS 'Корпус дома'
;
COMMENT ON COLUMN "Adresses"."porch" IS 'Номер подъезда дома'
;
COMMENT ON COLUMN "Adresses"."Apartment_number" IS 'Номер квартиры'
;
COMMENT ON COLUMN "Adresses"."ID_Street" IS 'Номер улицы'
;
COMMENT ON COLUMN "Adresses"."ID_house" IS 'ID_house'
;

-- Add keys for table Adresses

ALTER TABLE "Adresses" ADD CONSTRAINT "Key26" PRIMARY KEY ("ID_adress","ID_Street","ID_house")
;

ALTER TABLE "Adresses" ADD CONSTRAINT "Код адреса" UNIQUE ("ID_adress")
;

-- Table Streets

CREATE TABLE "Streets"(
 "ID_Street" Integer NOT NULL,
 "Street_Name" Character(256)
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Streets" IS 'Улицы'
;
COMMENT ON COLUMN "Streets"."ID_Street" IS 'Номер улицы'
;
COMMENT ON COLUMN "Streets"."Street_Name" IS 'Наименование улицы'
;

-- Add keys for table Streets

ALTER TABLE "Streets" ADD CONSTRAINT "Key27" PRIMARY KEY ("ID_Street")
;

ALTER TABLE "Streets" ADD CONSTRAINT "Номер улицы" UNIQUE ("ID_Street")
;

-- Table Houses

CREATE TABLE "Houses"(
 "ID_house" Integer NOT NULL,
 "House_number" Character(5) NOT NULL,
 "ID_Street" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Houses" IS 'Дома'
;
COMMENT ON COLUMN "Houses"."ID_house" IS 'ID_house'
;
COMMENT ON COLUMN "Houses"."House_number" IS 'Номер дома'
;
COMMENT ON COLUMN "Houses"."ID_Street" IS 'Номер улицы'
;

-- Add keys for table Houses

ALTER TABLE "Houses" ADD CONSTRAINT "Key28" PRIMARY KEY ("ID_Street","ID_house")
;

ALTER TABLE "Houses" ADD CONSTRAINT "ID_house" UNIQUE ("ID_house")
;

-- Table Users

CREATE TABLE "Users"(
 "ID Users" Integer NOT NULL,
 "Admin" Boolean DEFAULT False,
 "Login" Name NOT NULL,
 "Password" Text,
 "ID_doctor's" Integer NOT NULL,
 "Job_Number" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

COMMENT ON TABLE "Users" IS 'Пользователи'
;
COMMENT ON COLUMN "Users"."ID Users" IS 'ID Пользователя'
;
COMMENT ON COLUMN "Users"."Admin" IS 'Администратор'
;
COMMENT ON COLUMN "Users"."Login" IS 'Имя пользователя'
;
COMMENT ON COLUMN "Users"."Password" IS 'Пароль'
;
COMMENT ON COLUMN "Users"."ID_doctor's" IS 'Номер врача'
;
COMMENT ON COLUMN "Users"."Job_Number" IS 'Номер должности'
;

-- Add keys for table Users

ALTER TABLE "Users" ADD CONSTRAINT "PK_Users" PRIMARY KEY ("ID_doctor's","Job_Number","ID Users")
;

ALTER TABLE "Users" ADD CONSTRAINT "ID Пользователя" UNIQUE ("ID Users")
;
-- Create foreign keys (relationships) section ------------------------------------------------- 

ALTER TABLE "Hospital_buildings" ADD CONSTRAINT "ID_institutor" FOREIGN KEY ("ID_institution", "INN_KPP") REFERENCES "Medical_institution" ("ID_institution", "INN_KPP") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "ID_institutor" ON "Hospital_buildings" IS 'Номер учреждения'
;

ALTER TABLE "Cabinets" ADD CONSTRAINT "Institution_builder" FOREIGN KEY ("Institution_building_number", "ID_institution", "INN_KPP") REFERENCES "Hospital_buildings" ("Institution_building_number", "ID_institution", "INN_KPP") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Institution_builder" ON "Cabinets" IS 'Номер корпуса учреждения'
;

ALTER TABLE "Doctor's_schedules" ADD CONSTRAINT "Cabinet_number" FOREIGN KEY ("Institution_building_number", "ID_institution", "INN_KPP", "ID cabinet") REFERENCES "Cabinets" ("Institution_building_number", "ID_institution", "INN_KPP", "ID cabinet") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Cabinet_number" ON "Doctor's_schedules" IS 'Номер кабинета'
;

ALTER TABLE "Doctor's_schedules" ADD CONSTRAINT "Doctor_number" FOREIGN KEY ("ID_doctor's", "Job_Number") REFERENCES "Doctors" ("ID_doctor's", "Job_Number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Doctor_number" ON "Doctor's_schedules" IS 'Номер врача'
;

ALTER TABLE "Doctors" ADD CONSTRAINT "INN_Doctor" FOREIGN KEY ("INN") REFERENCES "Individuals" ("INN") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "INN_Doctor" ON "Doctors" IS 'ИНН врача'
;

ALTER TABLE "Medical_institution" ADD CONSTRAINT "INN_Medical_Institution" FOREIGN KEY ("INN_KPP") REFERENCES "Work_places" ("INN_KPP") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "INN_Medical_Institution" ON "Medical_institution" IS 'ИНН Лечебного учреждения'
;

ALTER TABLE "Doctors" ADD CONSTRAINT "Position_doctor" FOREIGN KEY ("Job_Number") REFERENCES "Job_Classifier" ("Job_Number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Position_doctor" ON "Doctors" IS 'Должность врача'
;

ALTER TABLE "Pre-appointment" ADD CONSTRAINT "Number_schedule_doctors" FOREIGN KEY ("Number_schedule_doctors", "ID_doctor's", "Job_Number") REFERENCES "Doctor's_schedules" ("Number_schedule_doctors", "ID_doctor's", "Job_Number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Number_schedule_doctors" ON "Pre-appointment" IS 'Расписание приёма'
;

ALTER TABLE "Individuals" ADD CONSTRAINT "Profession" FOREIGN KEY ("Job_Number") REFERENCES "Job_Classifier" ("Job_Number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Profession" ON "Individuals" IS 'Профессия'
;

ALTER TABLE "Individuals" ADD CONSTRAINT "job" FOREIGN KEY ("INN_KPP") REFERENCES "Work_places" ("INN_KPP") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "job" ON "Individuals" IS 'Место работы'
;

ALTER TABLE "Plots" ADD CONSTRAINT "Doctors_area" FOREIGN KEY ("ID_doctor's", "Job_Number") REFERENCES "Doctors" ("ID_doctor's", "Job_Number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Doctors_area" ON "Plots" IS 'Участки врачей'
;

ALTER TABLE "Borders_plots" ADD CONSTRAINT "area_addresses" FOREIGN KEY ("Plot_number", "ID_doctor's", "Job_Number") REFERENCES "Plots" ("Plot_number", "ID_doctor's", "Job_Number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "area_addresses" ON "Borders_plots" IS 'Адреса участков'
;

ALTER TABLE "Individuals" ADD CONSTRAINT "address" FOREIGN KEY ("ID_adress", "ID_Street", "ID_house") REFERENCES "Adresses" ("ID_adress", "ID_Street", "ID_house") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "address" ON "Individuals" IS 'Адрес'
;

ALTER TABLE "Hospital_records" ADD CONSTRAINT "Hospital_records" FOREIGN KEY ("Sick_leave_number") REFERENCES "Sick_leave" ("Sick_leave_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Hospital_records" ON "Hospital_records" IS 'Записи в больничном листе'
;

ALTER TABLE "Patient_Records" ADD CONSTRAINT "Hospital_in_card" FOREIGN KEY ("Sick_leave_number") REFERENCES "Sick_leave" ("Sick_leave_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Hospital_in_card" ON "Patient_Records" IS 'Больничный в карточке'
;

ALTER TABLE "Houses" ADD CONSTRAINT "Street_Houses" FOREIGN KEY ("ID_Street") REFERENCES "Streets" ("ID_Street") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Street_Houses" ON "Houses" IS 'Дома улицы'
;

ALTER TABLE "Borders_plots" ADD CONSTRAINT "Area_Streets_Houses" FOREIGN KEY ("ID_Street", "ID_house") REFERENCES "Houses" ("ID_Street", "ID_house") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Area_Streets_Houses" ON "Borders_plots" IS 'Дома улиц участков'
;

ALTER TABLE "Prescribed_treatment" ADD CONSTRAINT "Treatment_type" FOREIGN KEY ("Treatment_type_number") REFERENCES "Types_of_treatment" ("Treatment_type_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Treatment_type" ON "Prescribed_treatment" IS 'Вид лечения'
;

ALTER TABLE "Prescribed_treatment" ADD CONSTRAINT "Treatment_method" FOREIGN KEY ("Treatment_number") REFERENCES "Treatment_methods" ("Treatment_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Treatment_method" ON "Prescribed_treatment" IS 'Методы лечения'
;

ALTER TABLE "Prescribed_treatment" ADD CONSTRAINT "Reception_methods" FOREIGN KEY ("Reception_method_number") REFERENCES "Reception_methods" ("Reception_method_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Reception_methods" ON "Prescribed_treatment" IS 'Способы приёма'
;

ALTER TABLE "Prescribed_treatment" ADD CONSTRAINT "Doses" FOREIGN KEY ("Dosage_number") REFERENCES "Dosage" ("Dosage_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Doses" ON "Prescribed_treatment" IS 'Дозировки'
;

ALTER TABLE "Patient_Records" ADD CONSTRAINT "Treatment" FOREIGN KEY ("Number_ treatment_assigned") REFERENCES "Prescribed_treatment" ("Number_ treatment_assigned") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Treatment" ON "Patient_Records" IS 'Лечение'
;

ALTER TABLE "Users" ADD CONSTRAINT "Users" FOREIGN KEY ("ID_doctor's", "Job_Number") REFERENCES "Doctors" ("ID_doctor's", "Job_Number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Users" ON "Users" IS 'Пользователи'
;

ALTER TABLE "Pre-appointment" ADD CONSTRAINT "Appointment" FOREIGN KEY ("INN") REFERENCES "Individuals" ("INN") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Appointment" ON "Pre-appointment" IS 'Запись на приём'
;

ALTER TABLE "Adresses" ADD CONSTRAINT "address_home" FOREIGN KEY ("ID_Street", "ID_house") REFERENCES "Houses" ("ID_Street", "ID_house") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "address_home" ON "Adresses" IS 'Дом адреса'
;

ALTER TABLE "Patient_Records" ADD CONSTRAINT "date appointment" FOREIGN KEY ("Reception_Record_Number", "Number_schedule_doctors", "ID_doctor's", "Job_Number", "INN") REFERENCES "Pre-appointment" ("Reception_Record_Number", "Number_schedule_doctors", "ID_doctor's", "Job_Number", "INN") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "date appointment" ON "Patient_Records" IS 'Дата приёма'
;

ALTER TABLE "Patient_Records" ADD CONSTRAINT "Diagnosis_Patient" FOREIGN KEY ("ID_diagnos") REFERENCES "Diagnosis_Classifier" ("ID_diagnos") ON DELETE NO ACTION ON UPDATE NO ACTION
;

COMMENT ON CONSTRAINT "Diagnosis_Patient" ON "Patient_Records" IS 'Диагноз пациента'
;




