    #Grupo RUBY
    #Código que permite calcular un polinomio dado su orden y coeficientes

    def calcular_polinomio(n, coeficientes, x)
        resultado = 0
        for i in 0..n
            resultado += coeficientes[i] * x**i
        end
        resultado
    end
  
    def calcular_fact(n)
        if n == 0
          1
        else
          n * calcular_fact(n-1)
        end
    end

  puts "\n\t\t\tCALCULO DE POLINOMIO (an x ^ n + an-1 x ^ n-1 + … + a2 x ^ 2 + a1x + a0)"
  
  #Control de ingreso del orden 
  begin
    print "\nIngrese el orden del polinomio: "
    n = gets.chomp.to_i
  
    if n > 5
      puts "El orden del polinomio debe ser 5 o menos. Inténtelo de nuevo."
    end
  end while n > 5
  

  coeficientes = []
  
  #Bucle para ingreasr los coeficientes
  for i in 0..n
    print "\nIngrese el coeficiente #{i + 1}: "
    coeficientes << gets.chomp.to_i
    # coeficientes[i] = gets.chomp.to_i
  end
  
  #Ingresar x
  print "\nIngrese el valor de x a reemplazar: "
  x = gets.chomp.to_i
  
  #Bucle para imprimir la estructura del polinomio 
  print "\n"
  signo = "+"
  for i in 0..n
    if i == n
        signo = ""
    end
    print "#{coeficientes[i]} * #{x}^#{i} #{signo} "
  end

  #Resulados
  resultado = calcular_polinomio(n, coeficientes, x)
  puts "\nEl resultado del polinomio es: #{resultado}\n"
  
  if resultado < 20
    puts "\nEl factorial de #{resultado} es: #{calcular_fact(resultado)}"
  else
    puts "\nEl valor es muy grande para calcular su factorial"
  end
  