class
    CLOCK
create 
    make

feature
	make
    do
        print ("Hello World!")
    end

feature
    minutes: INTEGER

    hour: INTEGER
    do
        Result := minutes // 60
    end

    minute: INTEGER
    do
        Result := minutes \\ 60
    end

    set (hh: INTEGER; mm: INTEGER)
    require
        0 <= hh and hh < 24
        0 <= mm and mm < 60
    do
        minutes := hh * 60 + mm
    ensure
       hour = hh
       minute = mm
    end
end