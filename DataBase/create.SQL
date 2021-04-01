/*
Created: 17.01.2019
Modified: 01.08.2023
Model: PostgreSQL 10
Database: PostgreSQL 10
*/


-- Create tables section -------------------------------------------------

-- Table Medical_institution

CREATE TABLE "Medical_institution"(
 "ID_institution" Integer NOT NULL,
 "Naim" Character(256),
 "INN_KPP" Character(22) NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "Номер должности" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Medical_institution

ALTER TABLE "Medical_institution" ADD CONSTRAINT "Key1" PRIMARY KEY ("ID_institution","INN_KPP","ID_doctor's","Номер должности")
;

-- Table Hospital_buildings

CREATE TABLE "Hospital_buildings"(
 "Institution_building_number" Integer NOT NULL,
 "ID_institution" Integer NOT NULL,
 "INN_KPP" Character(22) NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "Номер должности" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Hospital_buildings

ALTER TABLE "Hospital_buildings" ADD CONSTRAINT "Key2" PRIMARY KEY ("Institution_building_number","ID_institution","INN_KPP","ID_doctor's","Номер должности")
;

-- Table Individuals

CREATE TABLE "Individuals"(
 "INN" Character(12) NOT NULL,
 "Family" Character(256),
 "Name" Character(256),
 "Last_Name" Character(256),
 "DOB" Date,
 "bpl" Character(256),
 "Insurance_policy" Character(12),
 "Phones" Character(256),
 "Электронная_почта" Character(256),
 "Номер должности" Integer NOT NULL,
 "INN_KPP" Character(22) NOT NULL,
 "ID_adress" Integer NOT NULL,
 "ID_Street" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table Individuals

CREATE INDEX "IX_address" ON "Individuals" ("ID_adress","ID_Street")
;

CREATE INDEX "IX_Profession" ON "Individuals" ("Номер должности")
;

-- Add keys for table Individuals

ALTER TABLE "Individuals" ADD CONSTRAINT "Key3" PRIMARY KEY ("INN","INN_KPP")
;

-- Table Doctors

CREATE TABLE "Doctors"(
 "ID_doctor's" Integer NOT NULL,
 "INN" Character(12) NOT NULL,
 "Номер должности" Integer NOT NULL,
 "INN_KPP" Character(22)
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table Doctors

CREATE INDEX "IX_INN_Doctor" ON "Doctors" ("INN","INN_KPP")
;

-- Add keys for table Doctors

ALTER TABLE "Doctors" ADD CONSTRAINT "Key4" PRIMARY KEY ("ID_doctor's","Номер должности")
;

-- Table Doctor's_schedules

CREATE TABLE "Doctor's_schedules"(
 "Number_schedule_doctors" Integer NOT NULL,
 "Date" Date,
 "Time" Time,
 "Cabinet_Number" Integer NOT NULL,
 "Institution_building_number" Integer NOT NULL,
 "ID_institution" Integer NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "INN_KPP" Character(22) NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "Номер должности" Integer NOT NULL,
 "Номер должности" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table Doctor's_schedules

CREATE INDEX "IX_Cabinet_number" ON "Doctor's_schedules" ("Cabinet_Number","Institution_building_number","ID_institution","INN_KPP","ID_doctor's","Номер должности")
;

-- Add keys for table Doctor's_schedules

ALTER TABLE "Doctor's_schedules" ADD CONSTRAINT "Key5" PRIMARY KEY ("Number_schedule_doctors","ID_doctor's","Номер должности")
;

-- Table Cabinets

CREATE TABLE "Cabinets"(
 "Cabinet_Number" Integer NOT NULL,
 "cabinet_name" Character(256),
 "Institution_building_number" Integer NOT NULL,
 "ID_institution" Integer NOT NULL,
 "INN_KPP" Character(22) NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "Номер должности" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Cabinets

ALTER TABLE "Cabinets" ADD CONSTRAINT "Key6" PRIMARY KEY ("Cabinet_Number","Institution_building_number","ID_institution","INN_KPP","ID_doctor's","Номер должности")
;

-- Table Pre-appointment

CREATE TABLE "Pre-appointment"(
 "Reception_Record_Number" Integer NOT NULL,
 "Number_schedule_doctors" Integer NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "INN" Character(12) NOT NULL,
 "INN_KPP" Character(22),
 "Номер должности" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table Pre-appointment

CREATE INDEX "IX_Appointment" ON "Pre-appointment" ("INN","INN_KPP")
;

-- Add keys for table Pre-appointment

ALTER TABLE "Pre-appointment" ADD CONSTRAINT "Key7" PRIMARY KEY ("Reception_Record_Number","Number_schedule_doctors","ID_doctor's","Номер должности")
;

-- Table Patient_Records

CREATE TABLE "Patient_Records"(
 "Patient_record_number" Integer NOT NULL,
 "Anamnes" Text,
 "Number_schedule_doctors" Integer NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "ID_diagnos" Integer NOT NULL,
 "Sick_leave_number" Integer NOT NULL,
 "Number_ treatment_assigned" Integer NOT NULL,
 "Номер должности" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table Patient_Records

CREATE INDEX "IX_Diagnosis" ON "Patient_Records" ("ID_diagnos")
;

-- Add keys for table Patient_Records

ALTER TABLE "Patient_Records" ADD CONSTRAINT "Key8" PRIMARY KEY ("Patient_record_number","Number_ treatment_assigned","Sick_leave_number","Number_schedule_doctors","ID_doctor's","Номер должности")
;

-- Table Plots

CREATE TABLE "Plots"(
 "Plot_number" Integer NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "Номер должности" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Plots

ALTER TABLE "Plots" ADD CONSTRAINT "Key10" PRIMARY KEY ("Plot_number","ID_doctor's","Номер должности")
;

-- Table Borders_plots

CREATE TABLE "Borders_plots"(
 "Border_number" Integer NOT NULL,
 "Plot_number" Integer NOT NULL,
 "ID_Street" Integer NOT NULL,
 "House_number" Character(5) NOT NULL,
 "ID_Street" Integer NOT NULL,
 "ID_doctor's" Integer NOT NULL,
 "Номер должности" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table Borders_plots

CREATE INDEX "IX_Area_Streets" ON "Borders_plots" ("ID_Street")
;

-- Add keys for table Borders_plots

ALTER TABLE "Borders_plots" ADD CONSTRAINT "Key11" PRIMARY KEY ("Border_number","Plot_number","House_number","ID_Street","ID_doctor's","Номер должности")
;

-- Table Job_Classifier

CREATE TABLE "Job_Classifier"(
 "Номер должности" Integer NOT NULL,
 "Job_title" Character(256)
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Job_Classifier

ALTER TABLE "Job_Classifier" ADD CONSTRAINT "Key13" PRIMARY KEY ("Номер должности")
;

-- Table Diagnosis_Classifier

CREATE TABLE "Diagnosis_Classifier"(
 "ID_diagnos" Integer NOT NULL,
 "diagnos_name" Character(256)
)
WITH (
 autovacuum_enabled=true)
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

-- Add keys for table Sick_leave

ALTER TABLE "Sick_leave" ADD CONSTRAINT "Key15" PRIMARY KEY ("Sick_leave_number")
;

-- Table Hospital_records

CREATE TABLE "Hospital_records"(
 "Hospital_record_number" Integer NOT NULL,
 "data_record" Date,
 "Sick_leave_number" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Hospital_records

ALTER TABLE "Hospital_records" ADD CONSTRAINT "Key16" PRIMARY KEY ("Hospital_record_number","Sick_leave_number")
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

-- Table Treatment_methods

CREATE TABLE "Treatment_methods"(
 "Treatment_number" Integer NOT NULL,
 "Treatment_number_name" Character(256)
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Treatment_methods

ALTER TABLE "Treatment_methods" ADD CONSTRAINT "Key18" PRIMARY KEY ("Treatment_number")
;

-- Table Types_of_treatment

CREATE TABLE "Types_of_treatment"(
 "Treatment_type_number" Integer NOT NULL,
 "Treatment_type_name" Character(256)
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Types_of_treatment

ALTER TABLE "Types_of_treatment" ADD CONSTRAINT "Key19" PRIMARY KEY ("Treatment_type_number")
;

-- Table Reception_methods

CREATE TABLE "Reception_methods"(
 "Reception_method_number" Integer NOT NULL,
 "Reception_method_name" Character(256)
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Reception_methods

ALTER TABLE "Reception_methods" ADD CONSTRAINT "Key20" PRIMARY KEY ("Reception_method_number")
;

-- Table Dosage

CREATE TABLE "Dosage"(
 "Dosage_number" Integer NOT NULL,
 "dosage_name" Character(256)
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Dosage

ALTER TABLE "Dosage" ADD CONSTRAINT "Key21" PRIMARY KEY ("Dosage_number")
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

-- Add keys for table Work_places

ALTER TABLE "Work_places" ADD CONSTRAINT "Key25" PRIMARY KEY ("INN_KPP")
;

-- Table Adresses

CREATE TABLE "Adresses"(
 "ID_adress" Integer NOT NULL,
 "Country" Character(256),
 "Region" Character(256),
 "Locality" Character(256),
 "Sity" Character(256),
 "index" Character(6),
 "Housing_house" Character(5),
 "porch" Character(3),
 "Apartment_number" Character(5),
 "ID_Street" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Adresses

ALTER TABLE "Adresses" ADD CONSTRAINT "Key26" PRIMARY KEY ("ID_adress","ID_Street")
;

-- Table Streets

CREATE TABLE "Streets"(
 "ID_Street" Integer NOT NULL,
 "Street_Name" Character(256)
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Streets

ALTER TABLE "Streets" ADD CONSTRAINT "Key27" PRIMARY KEY ("ID_Street")
;

-- Table Houses

CREATE TABLE "Houses"(
 "House_number" Character(5) NOT NULL,
 "ID_Street" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Houses

ALTER TABLE "Houses" ADD CONSTRAINT "Key28" PRIMARY KEY ("House_number","ID_Street")
;

-- Table Users

CREATE TABLE "Users"(
 "INN" Character(22) NOT NULL,
 "Admin" Boolean DEFAULT False
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table Users

ALTER TABLE "Users" ADD CONSTRAINT "PK_Users" PRIMARY KEY ("INN")
;
-- Create foreign keys (relationships) section ------------------------------------------------- 

ALTER TABLE "Hospital_buildings" ADD CONSTRAINT "ID_institutor" FOREIGN KEY ("ID_institution", "INN_KPP", "ID_doctor's", "Номер должности") REFERENCES "Medical_institution" ("ID_institution", "INN_KPP", "ID_doctor's", "Номер должности") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Cabinets" ADD CONSTRAINT "Institution_builder" FOREIGN KEY ("Institution_building_number", "ID_institution", "INN_KPP", "ID_doctor's", "Номер должности") REFERENCES "Hospital_buildings" ("Institution_building_number", "ID_institution", "INN_KPP", "ID_doctor's", "Номер должности") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Doctor's_schedules" ADD CONSTRAINT "Cabinet_number" FOREIGN KEY ("Cabinet_Number", "Institution_building_number", "ID_institution", "INN_KPP", "ID_doctor's", "Номер должности") REFERENCES "Cabinets" ("Cabinet_Number", "Institution_building_number", "ID_institution", "INN_KPP", "ID_doctor's", "Номер должности") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Doctor's_schedules" ADD CONSTRAINT "Doctor_number" FOREIGN KEY ("ID_doctor's", "Номер должности") REFERENCES "Doctors" ("ID_doctor's", "Номер должности") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Doctors" ADD CONSTRAINT "INN_Doctor" FOREIGN KEY ("INN", "INN_KPP") REFERENCES "Individuals" ("INN", "INN_KPP") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Medical_institution" ADD CONSTRAINT "INN_Medical_Institution" FOREIGN KEY ("INN_KPP") REFERENCES "Work_places" ("INN_KPP") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Doctors" ADD CONSTRAINT "Position_doctor" FOREIGN KEY ("Номер должности") REFERENCES "Job_Classifier" ("Номер должности") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Medical_institution" ADD CONSTRAINT "head_physician" FOREIGN KEY ("ID_doctor's", "Номер должности") REFERENCES "Doctors" ("ID_doctor's", "Номер должности") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Pre-appointment" ADD CONSTRAINT "Number_schedule_doctors" FOREIGN KEY ("Number_schedule_doctors", "ID_doctor's", "Номер должности") REFERENCES "Doctor's_schedules" ("Number_schedule_doctors", "ID_doctor's", "Номер должности") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Individuals" ADD CONSTRAINT "Profession" FOREIGN KEY ("Номер должности") REFERENCES "Job_Classifier" ("Номер должности") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Individuals" ADD CONSTRAINT "job" FOREIGN KEY ("INN_KPP") REFERENCES "Work_places" ("INN_KPP") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Plots" ADD CONSTRAINT "Doctors_area" FOREIGN KEY ("ID_doctor's", "Номер должности") REFERENCES "Doctors" ("ID_doctor's", "Номер должности") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Borders_plots" ADD CONSTRAINT "area_addresses" FOREIGN KEY ("Plot_number", "ID_doctor's", "Номер должности") REFERENCES "Plots" ("Plot_number", "ID_doctor's", "Номер должности") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Patient_Records" ADD CONSTRAINT "Docter_schedule_number" FOREIGN KEY ("Number_schedule_doctors", "ID_doctor's", "Номер должности") REFERENCES "Doctor's_schedules" ("Number_schedule_doctors", "ID_doctor's", "Номер должности") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Pre-appointment" ADD CONSTRAINT "Appointment" FOREIGN KEY ("INN", "INN_KPP") REFERENCES "Individuals" ("INN", "INN_KPP") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Patient_Records" ADD CONSTRAINT "Diagnosis" FOREIGN KEY ("ID_diagnos") REFERENCES "Diagnosis_Classifier" ("ID_diagnos") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Individuals" ADD CONSTRAINT "address" FOREIGN KEY ("ID_adress", "ID_Street") REFERENCES "Adresses" ("ID_adress", "ID_Street") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Hospital_records" ADD CONSTRAINT "Hospital_records" FOREIGN KEY ("Sick_leave_number") REFERENCES "Sick_leave" ("Sick_leave_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Patient_Records" ADD CONSTRAINT "Hospital_in_card" FOREIGN KEY ("Sick_leave_number") REFERENCES "Sick_leave" ("Sick_leave_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Adresses" ADD CONSTRAINT "Address_Street" FOREIGN KEY ("ID_Street") REFERENCES "Streets" ("ID_Street") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Borders_plots" ADD CONSTRAINT "Area_Streets" FOREIGN KEY ("ID_Street") REFERENCES "Streets" ("ID_Street") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Houses" ADD CONSTRAINT "Street_Houses" FOREIGN KEY ("ID_Street") REFERENCES "Streets" ("ID_Street") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Borders_plots" ADD CONSTRAINT "Area_Streets_Houses" FOREIGN KEY ("House_number", "ID_Street") REFERENCES "Houses" ("House_number", "ID_Street") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Prescribed_treatment" ADD CONSTRAINT "Treatment_type" FOREIGN KEY ("Treatment_type_number") REFERENCES "Types_of_treatment" ("Treatment_type_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Prescribed_treatment" ADD CONSTRAINT "Treatment_method" FOREIGN KEY ("Treatment_number") REFERENCES "Treatment_methods" ("Treatment_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Prescribed_treatment" ADD CONSTRAINT "Reception_methods" FOREIGN KEY ("Reception_method_number") REFERENCES "Reception_methods" ("Reception_method_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Prescribed_treatment" ADD CONSTRAINT "Doses" FOREIGN KEY ("Dosage_number") REFERENCES "Dosage" ("Dosage_number") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Patient_Records" ADD CONSTRAINT "Treatment" FOREIGN KEY ("Number_ treatment_assigned") REFERENCES "Prescribed_treatment" ("Number_ treatment_assigned") ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE "Users" ADD CONSTRAINT "Users" FOREIGN KEY ("INN", "INN") REFERENCES "Individuals" ("INN", "INN_KPP") ON DELETE NO ACTION ON UPDATE NO ACTION
;




