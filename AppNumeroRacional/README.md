# VISION DEL CONCEPTOR

## 1. Nombre:
   - **CNroRacional**

## 2. Descripción:
   - **Numerador y Denominador:**
     - Un número racional se expresa como una fracción en la forma `numerador/denominador`, donde:
       - El **numerador** puede ser cualquier número entero.
       - El **denominador** debe ser un entero positivo y no puede ser 0.
     - Ejemplos:
       - 5/2, -2/3, -2/5, 4/10 = 8/20 (simplificación)
     - **Nota:** Si el denominador es 0, el número es **indeterminado**.

   - **Número Racional Normalizado y Simplificado:**
     - Los números racionales deben estar **normalizados**:
       - El signo debe aparecer en el **numerador** (no en el denominador).
       - El **denominador** siempre debe ser positivo.
     - La fracción debe estar **simplificada** usando el Máximo Común Divisor (MCD).

   - **Operaciones Básicas con Números Racionales:**
     - Los números racionales permiten realizar:
       - **Suma**, **resta**, **multiplicación** y **división** entre fracciones.

## 3. Especificación de Número Racional:

### Elementos:
   - La fracción se representa como:
     - numerador/denominador
     - Donde:
       - **Numerador** es un número entero.
       - **Denominador** es un número entero positivo (distinto de 0).

### Operaciones:

1. **CNroRacional (Numerador, Denominador) → Número Racional**
   - **Tipo de operación:** Crea un número racional con los valores ingresados de numerador y denominador.
   - **Ejemplo:**
     - CNroRacional(3, 7) → 3/7
   - **Resultado:** Número racional 3/7.

2. **Modificar Numerador (Número Entero) → Número Racional Modificado**
   - **Tipo de operación:** Modifica el valor del numerador, manteniendo el denominador.
   - **Ejemplo:**
     - 3/7 → 5/7
   - **Resultado:** Número racional 5/7.

3. **Modificar Denominador (Número Entero) → Número Racional Modificado**
   - **Tipo de operación:** Modifica el valor del denominador, manteniendo el numerador.
   - **Ejemplo:**
     - 3/7 → 3/5
   - **Resultado:** Número racional 3/5.

4. **Seleccionar Numerador () → Número Entero**
   - **Tipo de operación:** Devuelve el valor actual del numerador.
   - **Ejemplo:** 
     - Para 3/5, el numerador es 3.
   - **Resultado:** Entero 3.

5. **Seleccionar Denominador () → Número Entero**
   - **Tipo de operación:** Devuelve el valor actual del denominador.
   - **Ejemplo:** 
     - Para 3/5, el denominador es 5.
   - **Resultado:** Entero 5.

### Operaciones Clásicas:

6. **Sumar (Número Racional) → Número Racional**
   - **Tipo de operación:** Suma dos fracciones.
   - **Fórmula:**
     - (a/b) + (c/d) = (a \* d + c \* b) / (b \* d)
   - **Ejemplo:**
     - (3/4) + (5/6) = (3 \* 6 + 5 \* 4) / (4 \* 6) = 19/12
   - **Resultado:** Número racional 19/12.

7. **Restar (Número Racional) → Número Racional**
   - **Tipo de operación:** Resta dos fracciones.
   - **Fórmula:**
     - (a/b) - (c/d) = (a \* d - c \* b) / (b \* d)
   - **Ejemplo:**
     - (3/4) - (5/6) = (3 \* 6 - 5 \* 4) / (4 \* 6) = -1/12
   - **Resultado:** Número racional -1/12.

8. **Multiplicar (Número Racional) → Número Racional**
   - **Tipo de operación:** Multiplica dos fracciones.
   - **Fórmula:**
     - (a/b) \* (c/d) = (a \* c) / (b \* d)
   - **Ejemplo:**
     - (3/4) \* (5/6) = (3 \* 5) / (4 \* 6) = 15/24 = 5/8
   - **Resultado:** Número racional 5/8.

9. **Dividir (Número Racional) → Número Racional**
   - **Tipo de operación:** Divide dos fracciones.
   - **Fórmula:**
     - (a/b) ÷ (c/d) = (a \* d) / (b \* c)
   - **Ejemplo:**
     - (3/4) ÷ (5/6) = (3 \* 6) / (4 \* 5) = 18/20 = 9/10
   - **Resultado:** Número racional 9/10.
