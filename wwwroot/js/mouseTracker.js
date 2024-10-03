let mouseCoordinates = [];

// Сбор координат мыши
document.addEventListener("mousemove", function (event) {
    const x = event.clientX;
    const y = event.clientY;
    const t = new Date().getTime();
    mouseCoordinates.push({ x, y, t });
});

// Функция для отправки данных на сервер
async function sendData() {
    if (mouseCoordinates.length === 0) {
        alert("Нет данных для отправки");
        return;
    }

    try {
        const response = await fetch("/api/mouse/save-coordinates", {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(mouseCoordinates),
        });

        if (!response.ok) {
            const errorText = await response.text(); // Читаем текст ошибки от сервера
            throw new Error(`Ошибка при отправке данных: ${response.status} ${errorText}`);
        }

        alert("Данные успешно отправлены");
        mouseCoordinates = []; // Очищаем массив после успешной отправки
    } catch (error) {
        console.error("Ошибка:", error); // Логируем ошибку в консоль
    }
}
