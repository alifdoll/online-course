KALO UDAH ADA DATABASE online_course
HAPUS DULU TERUS IMPORT ULANG YANG ADA DI FOLDER REFERENCES

LALU MASUKKAN COMMAND BERIKUT:

STUDENT		:

CREATE USER 'o_course_student'@'localhost' IDENTIFIED BY 'student'

GRANT ALL PRIVILEGES ON online_course.* TO 'o_course_student'@'localhost' WITH GRANT OPTION


INSTRUCTOR 	:

CREATE USER 'o_course_instruc'@'localhost' IDENTIFIED BY 'instructor'

GRANT ALL PRIVILEGES ON online_course.* TO 'o_course_instruc'@'localhost' WITH GRANT OPTION


ADMIN 		:

CREATE USER 'o_course_admin'@'localhost' IDENTIFIED BY 'admin'

GRANT ALL PRIVILEGES ON online_course.* TO 'o_course_admin'@'localhost' WITH GRANT OPTION