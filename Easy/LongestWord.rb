File.open(ARGV[0]).each_line do |line|
    mayor="";
    for palabras in line.split(" ")
       if palabras.length > mayor.length
           mayor=palabras;
       end
       
    end
    puts mayor;
end