
--EKLEME FONKSIYONU
CREATE OR REPLACE FUNCTION public.add_member(
    memberid INTEGER,
    membername VARCHAR(255),
    membersurname VARCHAR(255),
    memberphone VARCHAR(20),
    membermail VARCHAR(255)
)
RETURNS VOID
LANGUAGE plpgsql
AS $$
BEGIN
    INSERT INTO public.member (memberid, membername, membersurname, memberphone, membermail)
    VALUES (memberid, membername, membersurname, memberphone, membermail);
END;
$$;
--ornek uygulama
SELECT public.add_member(
    1, -- memberid
    'Mustafa', -- membername
    'Kılıç', -- membersurname
    '+905025554689', -- memberphone
    'mk@gmail.com' -- membermail
);








--ARAMA FONKSIYONU
CREATE OR REPLACE FUNCTION public.search_member_by_name(
    search_name VARCHAR(255)
)
RETURNS SETOF public.member
LANGUAGE plpgsql
AS $$
BEGIN
    RETURN QUERY
    SELECT *
    FROM public.member
    WHERE membername ILIKE '%' || search_name || '%';
END;
$$;

SELECT * FROM public.search_member_by_name('Mustafa'); --örnek deneme





--DELETE IŞLEMI
CREATE OR REPLACE FUNCTION public.delete_member(
    memberid INTEGER
)
RETURNS VOID
LANGUAGE plpgsql
AS $$
BEGIN
    DELETE FROM public.member
    WHERE memberid = memberid;
END;
$$;

SELECT public.delete_member(1); -- 1, silmek istediğimiz memberid değeri




--UPDATE IŞLEMI
CREATE OR REPLACE FUNCTION public.update_member(
    p_memberid INTEGER,
    p_membername VARCHAR(255),
    p_membersurname VARCHAR(255),
    p_memberphone VARCHAR(20),
    p_membermail VARCHAR(255)
)
RETURNS VOID
LANGUAGE plpgsql
AS $$
BEGIN
    UPDATE public.member
    SET
        membername = p_membername,
        membersurname = p_membersurname,
        memberphone = p_memberphone,
        membermail = p_membermail
    WHERE memberid = p_memberid;
END;
$$;
--fonksiyonun çalıştırılması
SELECT public.update_member(
    1, -- güncellenmek istenen memberid değeri
    'UpdatedName', -- yeni membername değeri
    'UpdatedSurname', -- yeni membersurname değeri
    'UpdatedPhone', -- yeni memberphone değeri
    'updated.email@example.com' -- yeni membermail değeri
);




