# Напишите программу, удаляющую из текста все слова, содержащие "абв"

def TextFilter(txt):
    return " ".join(filter(lambda word: "абв" not in word, txt.split(" ")))

print (TextFilter("Тест тест тесет абв тест абвтест тест теабвтест тест тестабв"))