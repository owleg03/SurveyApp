interface FoodEstablishmentDataProps {
    id: number;
    name: string;
    description: string;
    images: string[];
}

export const foodEstablishmentData: FoodEstablishmentDataProps[] = [
    {
        id: 1,
        name: "Опитування загальної якості життя",
        description: "Спрямоване на оцінку загальної якості життя пацієнтів, їх задоволення, емоційний стан, фізичне та психічне благополуччя.",
        images: ["src/assets/images/image5.png"],
    },
    {
        id: 2,
        name: "Медичне опитування",
        description: "Оцінка якості життя пацієнтів з певними медичними станами або хворобами, такими як хронічні захворювання, онкологічні захворювання, інфекції та інші.",
        images: ["src/assets/images/image2.png"],
    },
    {
        id: 3,
        name: "Опитування функціональності",
        description: "Оцінка рівня функціональних можливостей пацієнтів, їх здатності до виконання щоденних завдань, мобільності та інших фізичних параметрів.",
        images: ["src/assets/images/image3.png"],
    },
    {
        id: 4,
        name: "Психологічне опитування",
        description: "Оцінка психологічного стану пацієнтів, їх емоційного стану, душевного здоров'я та рівня стресу.",
        images: ["src/assets/images/image4.png"],
    },
    {
        id: 5,
        name: "Соціальне опитування",
        description: "Оцінка соціальних аспектів якості життя, таких як підтримка з боку родини, відносини зі спільнотою, інтеграція у суспільство та інше.",
        images: ["src/assets/images/image6.png"],
    },
    {
        id: 6,
        name: "Опитування задоволення лікуванням",
        description: "Оцінка задоволення пацієнтів лікуванням, ефективності та результатів медичних процедур та прийомів.",
        images: ["src/assets/images/image7.png"],
    },
    {
        id: 7,
        name: "Опитування про суб'єктивне самопочуття",
        description: "Оцінка суб'єктивних відчуттів пацієнтів щодо їх власного стану здоров'я та самопочуття.",
        images: ["src/assets/images/image8.png"],
    },
];
