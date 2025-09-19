# 📌 Comandos Git Básicos

Estos son los comandos más utilizados en Git para el manejo de repositorios:

## ⚙️ Configuración Inicial

```bash
git config --global user.name "Tu Nombre"
git config --global user.email "tuemail@example.com"

**📂 Repositorios**
git init
git clone URL_DEL_REPOSITORIO

**📄 Archivos**
git status
git add archivo.txt
git add .

**📝 Commits**
git commit -m "mensaje del commit"

**🌐 Repositorio Remoto**
git remote add origin URL_DEL_REPOSITORIO
git push origin main
git pull origin main

