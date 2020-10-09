function gradingStudents(grades) {
    for (let i in grades) {
        let grade = grades[i];
        if (grade >= 38) {
            while (grade % 5 !== 0) grade++;
            if (grade - grades[i] < 3) {
                grades[i] = grade;
            }
        }
    }
    return grades;
}
