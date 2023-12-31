PGDMP         &                {            GYM    12.17    12.17 k    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16393    GYM    DATABASE     �   CREATE DATABASE "GYM" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Turkish_T�rkiye.1254' LC_CTYPE = 'Turkish_T�rkiye.1254';
    DROP DATABASE "GYM";
                postgres    false                        2615    24683 	   Equipment    SCHEMA        CREATE SCHEMA "Equipment";
    DROP SCHEMA "Equipment";
                postgres    false            �            1255    32821 _   add_member(integer, character varying, character varying, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.add_member(memberid integer, membername character varying, membersurname character varying, memberphone character varying, membermail character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO public.member (memberid, membername, membersurname, memberphone, membermail)
    VALUES (memberid, membername, membersurname, memberphone, membermail);
END;
$$;
 �   DROP FUNCTION public.add_member(memberid integer, membername character varying, membersurname character varying, memberphone character varying, membermail character varying);
       public          postgres    false            �            1255    24801    addmembertest()    FUNCTION     �   CREATE FUNCTION public.addmembertest() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
 begin
 update totalmember set ttlmember=ttlmember+1;
 return new;
 end;
 $$;
 &   DROP FUNCTION public.addmembertest();
       public          postgres    false            �            1255    24844    addpersoneltest()    FUNCTION     �   CREATE FUNCTION public.addpersoneltest() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update totalpersonel set ttlpersonel=ttlpersonel+1;
return new;
end;
$$;
 (   DROP FUNCTION public.addpersoneltest();
       public          postgres    false            �            1255    32823    delete_member(integer)    FUNCTION     �   CREATE FUNCTION public.delete_member(memberid integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    DELETE FROM public.member
    WHERE memberid = memberid;
END;
$$;
 6   DROP FUNCTION public.delete_member(memberid integer);
       public          postgres    false            �            1255    24803    deletemembertest()    FUNCTION     �   CREATE FUNCTION public.deletemembertest() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update totalmember set ttlmember=ttlmember-1;
return new;
end;
$$;
 )   DROP FUNCTION public.deletemembertest();
       public          postgres    false            �            1255    24846    deletepersoneltest()    FUNCTION     �   CREATE FUNCTION public.deletepersoneltest() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update totalpersonel set ttlpersonel=ttlpersonel-1;
return new;
end;
$$;
 +   DROP FUNCTION public.deletepersoneltest();
       public          postgres    false            �            1259    16394    member    TABLE       CREATE TABLE public.member (
    memberid integer NOT NULL,
    membername character varying(15) NOT NULL,
    membersurname character varying(15) NOT NULL,
    memberphone character varying(14) NOT NULL,
    membermail character varying NOT NULL,
    staff integer
);
    DROP TABLE public.member;
       public         heap    postgres    false            �            1255    32822 (   search_member_by_name(character varying)    FUNCTION       CREATE FUNCTION public.search_member_by_name(search_name character varying) RETURNS SETOF public.member
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY
    SELECT *
    FROM public.member
    WHERE membername ILIKE '%' || search_name || '%';
END;
$$;
 K   DROP FUNCTION public.search_member_by_name(search_name character varying);
       public          postgres    false    203            �            1255    32824 b   update_member(integer, character varying, character varying, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.update_member(p_memberid integer, p_membername character varying, p_membersurname character varying, p_memberphone character varying, p_membermail character varying) RETURNS void
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
 �   DROP FUNCTION public.update_member(p_memberid integer, p_membername character varying, p_membersurname character varying, p_memberphone character varying, p_membermail character varying);
       public          postgres    false            �            1259    24692    eqbench    TABLE     |   CREATE TABLE "Equipment".eqbench (
    equipmentid integer NOT NULL,
    benchdefinition character varying(150) NOT NULL
);
     DROP TABLE "Equipment".eqbench;
    	   Equipment         heap    postgres    false    8            �            1259    24732    eqbike    TABLE     z   CREATE TABLE "Equipment".eqbike (
    equipmentid integer NOT NULL,
    bikedefinition character varying(150) NOT NULL
);
    DROP TABLE "Equipment".eqbike;
    	   Equipment         heap    postgres    false    8            �            1259    24697    eqcablemachine    TABLE     �   CREATE TABLE "Equipment".eqcablemachine (
    equipmentid integer NOT NULL,
    cablemachinedefinition character varying(150) NOT NULL
);
 '   DROP TABLE "Equipment".eqcablemachine;
    	   Equipment         heap    postgres    false    8            �            1259    24712    eqchestpress    TABLE     �   CREATE TABLE "Equipment".eqchestpress (
    equipmentid integer NOT NULL,
    chestpressdefinition character varying(150) NOT NULL
);
 %   DROP TABLE "Equipment".eqchestpress;
    	   Equipment         heap    postgres    false    8            �            1259    24717    eqcurlmachine    TABLE     �   CREATE TABLE "Equipment".eqcurlmachine (
    equipmentid integer NOT NULL,
    curlmachinedefinition character varying(150) NOT NULL
);
 &   DROP TABLE "Equipment".eqcurlmachine;
    	   Equipment         heap    postgres    false    8            �            1259    24722 
   eqdumbells    TABLE     �   CREATE TABLE "Equipment".eqdumbells (
    equipmentid integer NOT NULL,
    dumbellsdefinition character varying(150) NOT NULL
);
 #   DROP TABLE "Equipment".eqdumbells;
    	   Equipment         heap    postgres    false    8            �            1259    24707    eqlattpulldown    TABLE     �   CREATE TABLE "Equipment".eqlattpulldown (
    equipmentid integer NOT NULL,
    lattpulldowndefinition character varying(150) NOT NULL
);
 '   DROP TABLE "Equipment".eqlattpulldown;
    	   Equipment         heap    postgres    false    8            �            1259    24727    eqlegextension    TABLE     �   CREATE TABLE "Equipment".eqlegextension (
    equipmentid integer NOT NULL,
    legextensiondefinition character varying(150) NOT NULL
);
 '   DROP TABLE "Equipment".eqlegextension;
    	   Equipment         heap    postgres    false    8            �            1259    24702    eqtreadmill    TABLE     �   CREATE TABLE "Equipment".eqtreadmill (
    equipmentid integer NOT NULL,
    treadmilldefinition character varying(150) NOT NULL
);
 $   DROP TABLE "Equipment".eqtreadmill;
    	   Equipment         heap    postgres    false    8            �            1259    24686 	   equipment    TABLE     �   CREATE TABLE "Equipment".equipment (
    equipmentid integer NOT NULL,
    equipmentname character varying(40) NOT NULL,
    equipmentdefinition character varying(150) NOT NULL
);
 "   DROP TABLE "Equipment".equipment;
    	   Equipment         heap    postgres    false    8            �            1259    24684    equipment_equipmentid_seq    SEQUENCE     �   CREATE SEQUENCE "Equipment".equipment_equipmentid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 5   DROP SEQUENCE "Equipment".equipment_equipmentid_seq;
    	   Equipment          postgres    false    218    8            �           0    0    equipment_equipmentid_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE "Equipment".equipment_equipmentid_seq OWNED BY "Equipment".equipment.equipmentid;
       	   Equipment          postgres    false    217            �            1259    16484 	   equipment    TABLE     �   CREATE TABLE public.equipment (
    equipmentid integer NOT NULL,
    equipmentname character varying NOT NULL,
    staff integer
);
    DROP TABLE public.equipment;
       public         heap    postgres    false            �            1259    16640    eqbench    TABLE     �   CREATE TABLE public.eqbench (
    equipmentid integer,
    benchdefinition character varying(200)
)
INHERITS (public.equipment);
    DROP TABLE public.eqbench;
       public         heap    postgres    false    207            �            1259    16648    eqbike    TABLE        CREATE TABLE public.eqbike (
    equipmentid integer,
    bikedefinition character varying(100)
)
INHERITS (public.equipment);
    DROP TABLE public.eqbike;
       public         heap    postgres    false    207            �            1259    16656    eqcablemachine    TABLE     �   CREATE TABLE public.eqcablemachine (
    equipmentid integer,
    cablemachinedefinition character varying(80)
)
INHERITS (public.equipment);
 "   DROP TABLE public.eqcablemachine;
       public         heap    postgres    false    207            �            1259    16664    eqchestpress    TABLE     �   CREATE TABLE public.eqchestpress (
    equipmentid integer,
    chestpressdefinition character varying(80)
)
INHERITS (public.equipment);
     DROP TABLE public.eqchestpress;
       public         heap    postgres    false    207            �            1259    16673    eqcurlmachine    TABLE     �   CREATE TABLE public.eqcurlmachine (
    equipmentid integer,
    curlmachinedefinition character varying(50)
)
INHERITS (public.equipment);
 !   DROP TABLE public.eqcurlmachine;
       public         heap    postgres    false    207            �            1259    16681 
   eqdumbells    TABLE     �   CREATE TABLE public.eqdumbells (
    equipmentid integer,
    dumbelssdefinition character varying(80)
)
INHERITS (public.equipment);
    DROP TABLE public.eqdumbells;
       public         heap    postgres    false    207            �            1259    16689    eqlattpulldown    TABLE     �   CREATE TABLE public.eqlattpulldown (
    equipmentid integer,
    lattpulldowndefinition character varying(80)
)
INHERITS (public.equipment);
 "   DROP TABLE public.eqlattpulldown;
       public         heap    postgres    false    207            �            1259    16697    eqlegextension    TABLE     �   CREATE TABLE public.eqlegextension (
    equipmentid integer,
    legextensiondefinition character varying(120)
)
INHERITS (public.equipment);
 "   DROP TABLE public.eqlegextension;
       public         heap    postgres    false    207            �            1259    16705    eqtreadmill    TABLE     �   CREATE TABLE public.eqtreadmill (
    equipmentid integer,
    treadmilldefinition character varying(80)
)
INHERITS (public.equipment);
    DROP TABLE public.eqtreadmill;
       public         heap    postgres    false    207            �            1259    16434 
   membership    TABLE     �   CREATE TABLE public.membership (
    membershipid integer NOT NULL,
    membershippay character varying NOT NULL,
    membershipdate character varying NOT NULL,
    memberid integer
);
    DROP TABLE public.membership;
       public         heap    postgres    false            �            1259    16399    staff    TABLE     �   CREATE TABLE public.staff (
    staffid integer NOT NULL,
    staffname character varying(15) NOT NULL,
    staffsurname character varying(15) NOT NULL,
    staffphone character varying(14) NOT NULL,
    staffmail character varying NOT NULL
);
    DROP TABLE public.staff;
       public         heap    postgres    false            �            1259    16468    totalmember    TABLE     ;   CREATE TABLE public.totalmember (
    ttlmember integer
);
    DROP TABLE public.totalmember;
       public         heap    postgres    false            �            1259    24841    totalpersonel    TABLE     ?   CREATE TABLE public.totalpersonel (
    ttlpersonel integer
);
 !   DROP TABLE public.totalpersonel;
       public         heap    postgres    false            �
           2604    24689    equipment equipmentid    DEFAULT     �   ALTER TABLE ONLY "Equipment".equipment ALTER COLUMN equipmentid SET DEFAULT nextval('"Equipment".equipment_equipmentid_seq'::regclass);
 I   ALTER TABLE "Equipment".equipment ALTER COLUMN equipmentid DROP DEFAULT;
    	   Equipment          postgres    false    218    217    218            �          0    24692    eqbench 
   TABLE DATA           D   COPY "Equipment".eqbench (equipmentid, benchdefinition) FROM stdin;
 	   Equipment          postgres    false    219   �       �          0    24732    eqbike 
   TABLE DATA           B   COPY "Equipment".eqbike (equipmentid, bikedefinition) FROM stdin;
 	   Equipment          postgres    false    227   *�       �          0    24697    eqcablemachine 
   TABLE DATA           R   COPY "Equipment".eqcablemachine (equipmentid, cablemachinedefinition) FROM stdin;
 	   Equipment          postgres    false    220   G�       �          0    24712    eqchestpress 
   TABLE DATA           N   COPY "Equipment".eqchestpress (equipmentid, chestpressdefinition) FROM stdin;
 	   Equipment          postgres    false    223   d�       �          0    24717    eqcurlmachine 
   TABLE DATA           P   COPY "Equipment".eqcurlmachine (equipmentid, curlmachinedefinition) FROM stdin;
 	   Equipment          postgres    false    224   ��       �          0    24722 
   eqdumbells 
   TABLE DATA           J   COPY "Equipment".eqdumbells (equipmentid, dumbellsdefinition) FROM stdin;
 	   Equipment          postgres    false    225   ��       �          0    24707    eqlattpulldown 
   TABLE DATA           R   COPY "Equipment".eqlattpulldown (equipmentid, lattpulldowndefinition) FROM stdin;
 	   Equipment          postgres    false    222   ��       �          0    24727    eqlegextension 
   TABLE DATA           R   COPY "Equipment".eqlegextension (equipmentid, legextensiondefinition) FROM stdin;
 	   Equipment          postgres    false    226   ؄       �          0    24702    eqtreadmill 
   TABLE DATA           L   COPY "Equipment".eqtreadmill (equipmentid, treadmilldefinition) FROM stdin;
 	   Equipment          postgres    false    221   ��       �          0    24686 	   equipment 
   TABLE DATA           Y   COPY "Equipment".equipment (equipmentid, equipmentname, equipmentdefinition) FROM stdin;
 	   Equipment          postgres    false    218   �       �          0    16640    eqbench 
   TABLE DATA           U   COPY public.eqbench (equipmentid, equipmentname, benchdefinition, staff) FROM stdin;
    public          postgres    false    208   /�       �          0    16648    eqbike 
   TABLE DATA           S   COPY public.eqbike (equipmentid, equipmentname, bikedefinition, staff) FROM stdin;
    public          postgres    false    209   ΅       �          0    16656    eqcablemachine 
   TABLE DATA           c   COPY public.eqcablemachine (equipmentid, equipmentname, cablemachinedefinition, staff) FROM stdin;
    public          postgres    false    210   A�       �          0    16664    eqchestpress 
   TABLE DATA           _   COPY public.eqchestpress (equipmentid, equipmentname, chestpressdefinition, staff) FROM stdin;
    public          postgres    false    211   ��       �          0    16673    eqcurlmachine 
   TABLE DATA           a   COPY public.eqcurlmachine (equipmentid, equipmentname, curlmachinedefinition, staff) FROM stdin;
    public          postgres    false    212   4�       �          0    16681 
   eqdumbells 
   TABLE DATA           [   COPY public.eqdumbells (equipmentid, equipmentname, dumbelssdefinition, staff) FROM stdin;
    public          postgres    false    213   ��       �          0    16689    eqlattpulldown 
   TABLE DATA           c   COPY public.eqlattpulldown (equipmentid, equipmentname, lattpulldowndefinition, staff) FROM stdin;
    public          postgres    false    214   �       �          0    16697    eqlegextension 
   TABLE DATA           c   COPY public.eqlegextension (equipmentid, equipmentname, legextensiondefinition, staff) FROM stdin;
    public          postgres    false    215   w�       �          0    16705    eqtreadmill 
   TABLE DATA           ]   COPY public.eqtreadmill (equipmentid, equipmentname, treadmilldefinition, staff) FROM stdin;
    public          postgres    false    216   ��       �          0    16484 	   equipment 
   TABLE DATA           F   COPY public.equipment (equipmentid, equipmentname, staff) FROM stdin;
    public          postgres    false    207   m�       �          0    16394    member 
   TABLE DATA           e   COPY public.member (memberid, membername, membersurname, memberphone, membermail, staff) FROM stdin;
    public          postgres    false    203   ��       �          0    16434 
   membership 
   TABLE DATA           [   COPY public.membership (membershipid, membershippay, membershipdate, memberid) FROM stdin;
    public          postgres    false    205   ��       �          0    16399    staff 
   TABLE DATA           X   COPY public.staff (staffid, staffname, staffsurname, staffphone, staffmail) FROM stdin;
    public          postgres    false    204   �       �          0    16468    totalmember 
   TABLE DATA           0   COPY public.totalmember (ttlmember) FROM stdin;
    public          postgres    false    206   ��       �          0    24841    totalpersonel 
   TABLE DATA           4   COPY public.totalpersonel (ttlpersonel) FROM stdin;
    public          postgres    false    228   ��       �           0    0    equipment_equipmentid_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('"Equipment".equipment_equipmentid_seq', 1, false);
       	   Equipment          postgres    false    217                       2606    24696    eqbench eqbenchPK 
   CONSTRAINT     _   ALTER TABLE ONLY "Equipment".eqbench
    ADD CONSTRAINT "eqbenchPK" PRIMARY KEY (equipmentid);
 B   ALTER TABLE ONLY "Equipment".eqbench DROP CONSTRAINT "eqbenchPK";
    	   Equipment            postgres    false    219            (           2606    24736    eqbike eqbikePK 
   CONSTRAINT     ]   ALTER TABLE ONLY "Equipment".eqbike
    ADD CONSTRAINT "eqbikePK" PRIMARY KEY (equipmentid);
 @   ALTER TABLE ONLY "Equipment".eqbike DROP CONSTRAINT "eqbikePK";
    	   Equipment            postgres    false    227                       2606    24701    eqcablemachine eqcablemachinePK 
   CONSTRAINT     m   ALTER TABLE ONLY "Equipment".eqcablemachine
    ADD CONSTRAINT "eqcablemachinePK" PRIMARY KEY (equipmentid);
 P   ALTER TABLE ONLY "Equipment".eqcablemachine DROP CONSTRAINT "eqcablemachinePK";
    	   Equipment            postgres    false    220                        2606    24716    eqchestpress eqchestpressPK 
   CONSTRAINT     i   ALTER TABLE ONLY "Equipment".eqchestpress
    ADD CONSTRAINT "eqchestpressPK" PRIMARY KEY (equipmentid);
 L   ALTER TABLE ONLY "Equipment".eqchestpress DROP CONSTRAINT "eqchestpressPK";
    	   Equipment            postgres    false    223            "           2606    24721    eqcurlmachine eqcurlmachinePK 
   CONSTRAINT     k   ALTER TABLE ONLY "Equipment".eqcurlmachine
    ADD CONSTRAINT "eqcurlmachinePK" PRIMARY KEY (equipmentid);
 N   ALTER TABLE ONLY "Equipment".eqcurlmachine DROP CONSTRAINT "eqcurlmachinePK";
    	   Equipment            postgres    false    224            $           2606    24726    eqdumbells eqdumbellsPK 
   CONSTRAINT     e   ALTER TABLE ONLY "Equipment".eqdumbells
    ADD CONSTRAINT "eqdumbellsPK" PRIMARY KEY (equipmentid);
 H   ALTER TABLE ONLY "Equipment".eqdumbells DROP CONSTRAINT "eqdumbellsPK";
    	   Equipment            postgres    false    225                       2606    24711     eqlattpulldown eqlattpulldownbPK 
   CONSTRAINT     n   ALTER TABLE ONLY "Equipment".eqlattpulldown
    ADD CONSTRAINT "eqlattpulldownbPK" PRIMARY KEY (equipmentid);
 Q   ALTER TABLE ONLY "Equipment".eqlattpulldown DROP CONSTRAINT "eqlattpulldownbPK";
    	   Equipment            postgres    false    222            &           2606    24731    eqlegextension eqlegextensionPK 
   CONSTRAINT     m   ALTER TABLE ONLY "Equipment".eqlegextension
    ADD CONSTRAINT "eqlegextensionPK" PRIMARY KEY (equipmentid);
 P   ALTER TABLE ONLY "Equipment".eqlegextension DROP CONSTRAINT "eqlegextensionPK";
    	   Equipment            postgres    false    226                       2606    24706    eqtreadmill eqtreadmillPK 
   CONSTRAINT     g   ALTER TABLE ONLY "Equipment".eqtreadmill
    ADD CONSTRAINT "eqtreadmillPK" PRIMARY KEY (equipmentid);
 J   ALTER TABLE ONLY "Equipment".eqtreadmill DROP CONSTRAINT "eqtreadmillPK";
    	   Equipment            postgres    false    221                       2606    24691    equipment equipmentPK 
   CONSTRAINT     c   ALTER TABLE ONLY "Equipment".equipment
    ADD CONSTRAINT "equipmentPK" PRIMARY KEY (equipmentid);
 F   ALTER TABLE ONLY "Equipment".equipment DROP CONSTRAINT "equipmentPK";
    	   Equipment            postgres    false    218            �
           2606    16398    member Member_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.member
    ADD CONSTRAINT "Member_pkey" PRIMARY KEY (memberid);
 >   ALTER TABLE ONLY public.member DROP CONSTRAINT "Member_pkey";
       public            postgres    false    203                       2606    16647    eqbench eqbench_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.eqbench
    ADD CONSTRAINT eqbench_pkey PRIMARY KEY (equipmentid);
 >   ALTER TABLE ONLY public.eqbench DROP CONSTRAINT eqbench_pkey;
       public            postgres    false    208                       2606    16655    eqbike eqbike_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.eqbike
    ADD CONSTRAINT eqbike_pkey PRIMARY KEY (equipmentid);
 <   ALTER TABLE ONLY public.eqbike DROP CONSTRAINT eqbike_pkey;
       public            postgres    false    209                       2606    16663 "   eqcablemachine eqcablemachine_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.eqcablemachine
    ADD CONSTRAINT eqcablemachine_pkey PRIMARY KEY (equipmentid);
 L   ALTER TABLE ONLY public.eqcablemachine DROP CONSTRAINT eqcablemachine_pkey;
       public            postgres    false    210            
           2606    16671    eqchestpress eqchestpress_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public.eqchestpress
    ADD CONSTRAINT eqchestpress_pkey PRIMARY KEY (equipmentid);
 H   ALTER TABLE ONLY public.eqchestpress DROP CONSTRAINT eqchestpress_pkey;
       public            postgres    false    211                       2606    16680     eqcurlmachine eqcurlmachine_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public.eqcurlmachine
    ADD CONSTRAINT eqcurlmachine_pkey PRIMARY KEY (equipmentid);
 J   ALTER TABLE ONLY public.eqcurlmachine DROP CONSTRAINT eqcurlmachine_pkey;
       public            postgres    false    212                       2606    16688    eqdumbells eqdumbells_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.eqdumbells
    ADD CONSTRAINT eqdumbells_pkey PRIMARY KEY (equipmentid);
 D   ALTER TABLE ONLY public.eqdumbells DROP CONSTRAINT eqdumbells_pkey;
       public            postgres    false    213                       2606    16696 "   eqlattpulldown eqlattpulldown_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.eqlattpulldown
    ADD CONSTRAINT eqlattpulldown_pkey PRIMARY KEY (equipmentid);
 L   ALTER TABLE ONLY public.eqlattpulldown DROP CONSTRAINT eqlattpulldown_pkey;
       public            postgres    false    214                       2606    16704 "   eqlegextension eqlegextension_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.eqlegextension
    ADD CONSTRAINT eqlegextension_pkey PRIMARY KEY (equipmentid);
 L   ALTER TABLE ONLY public.eqlegextension DROP CONSTRAINT eqlegextension_pkey;
       public            postgres    false    215                       2606    16712    eqtreadmill eqtreadmill_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.eqtreadmill
    ADD CONSTRAINT eqtreadmill_pkey PRIMARY KEY (equipmentid);
 F   ALTER TABLE ONLY public.eqtreadmill DROP CONSTRAINT eqtreadmill_pkey;
       public            postgres    false    216                       2606    16491    equipment equipment_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.equipment
    ADD CONSTRAINT equipment_pkey PRIMARY KEY (equipmentid);
 B   ALTER TABLE ONLY public.equipment DROP CONSTRAINT equipment_pkey;
       public            postgres    false    207            �
           2606    16441    membership membership_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.membership
    ADD CONSTRAINT membership_pkey PRIMARY KEY (membershipid);
 D   ALTER TABLE ONLY public.membership DROP CONSTRAINT membership_pkey;
       public            postgres    false    205            �
           2606    16406    staff staff_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.staff
    ADD CONSTRAINT staff_pkey PRIMARY KEY (staffid);
 :   ALTER TABLE ONLY public.staff DROP CONSTRAINT staff_pkey;
       public            postgres    false    204                       1259    16718    fki_eqstaff_fk    INDEX     E   CREATE INDEX fki_eqstaff_fk ON public.equipment USING btree (staff);
 "   DROP INDEX public.fki_eqstaff_fk;
       public            postgres    false    207            �
           1259    16459    fki_membersh_fk    INDEX     J   CREATE INDEX fki_membersh_fk ON public.membership USING btree (memberid);
 #   DROP INDEX public.fki_membersh_fk;
       public            postgres    false    205            �
           1259    16453    fki_memberstaff_foreignk    INDEX     L   CREATE INDEX fki_memberstaff_foreignk ON public.member USING btree (staff);
 ,   DROP INDEX public.fki_memberstaff_foreignk;
       public            postgres    false    203            �
           1259    16447    fki_memberstaff_foreignkey    INDEX     Q   CREATE INDEX fki_memberstaff_foreignkey ON public.member USING btree (memberid);
 .   DROP INDEX public.fki_memberstaff_foreignkey;
       public            postgres    false    203            2           2620    24802    member addmembertrig    TRIGGER     q   CREATE TRIGGER addmembertrig AFTER INSERT ON public.member FOR EACH ROW EXECUTE FUNCTION public.addmembertest();
 -   DROP TRIGGER addmembertrig ON public.member;
       public          postgres    false    229    203            4           2620    24845    staff addpersoneltrig    TRIGGER     t   CREATE TRIGGER addpersoneltrig AFTER INSERT ON public.staff FOR EACH ROW EXECUTE FUNCTION public.addpersoneltest();
 .   DROP TRIGGER addpersoneltrig ON public.staff;
       public          postgres    false    234    204            3           2620    24804    member deletemembertrig    TRIGGER     w   CREATE TRIGGER deletemembertrig AFTER DELETE ON public.member FOR EACH ROW EXECUTE FUNCTION public.deletemembertest();
 0   DROP TRIGGER deletemembertrig ON public.member;
       public          postgres    false    230    203            5           2620    24847    staff deletepersoneltrig    TRIGGER     z   CREATE TRIGGER deletepersoneltrig AFTER DELETE ON public.staff FOR EACH ROW EXECUTE FUNCTION public.deletepersoneltest();
 1   DROP TRIGGER deletepersoneltrig ON public.staff;
       public          postgres    false    235    204            )           2606    24737    eqbench equipbench    FK CONSTRAINT     �   ALTER TABLE ONLY "Equipment".eqbench
    ADD CONSTRAINT equipbench FOREIGN KEY (equipmentid) REFERENCES "Equipment".equipment(equipmentid) ON UPDATE CASCADE ON DELETE CASCADE;
 A   ALTER TABLE ONLY "Equipment".eqbench DROP CONSTRAINT equipbench;
    	   Equipment          postgres    false    218    2838    219            1           2606    24742    eqbike equipbike    FK CONSTRAINT     �   ALTER TABLE ONLY "Equipment".eqbike
    ADD CONSTRAINT equipbike FOREIGN KEY (equipmentid) REFERENCES "Equipment".equipment(equipmentid) ON UPDATE CASCADE ON DELETE CASCADE;
 ?   ALTER TABLE ONLY "Equipment".eqbike DROP CONSTRAINT equipbike;
    	   Equipment          postgres    false    227    218    2838            *           2606    24747     eqcablemachine equipcablemachine    FK CONSTRAINT     �   ALTER TABLE ONLY "Equipment".eqcablemachine
    ADD CONSTRAINT equipcablemachine FOREIGN KEY (equipmentid) REFERENCES "Equipment".equipment(equipmentid) ON UPDATE CASCADE ON DELETE CASCADE;
 O   ALTER TABLE ONLY "Equipment".eqcablemachine DROP CONSTRAINT equipcablemachine;
    	   Equipment          postgres    false    218    2838    220            -           2606    24752    eqchestpress equipchestpress    FK CONSTRAINT     �   ALTER TABLE ONLY "Equipment".eqchestpress
    ADD CONSTRAINT equipchestpress FOREIGN KEY (equipmentid) REFERENCES "Equipment".equipment(equipmentid) ON UPDATE CASCADE ON DELETE CASCADE;
 K   ALTER TABLE ONLY "Equipment".eqchestpress DROP CONSTRAINT equipchestpress;
    	   Equipment          postgres    false    218    223    2838            .           2606    24757    eqcurlmachine equipcurlmachine    FK CONSTRAINT     �   ALTER TABLE ONLY "Equipment".eqcurlmachine
    ADD CONSTRAINT equipcurlmachine FOREIGN KEY (equipmentid) REFERENCES "Equipment".equipment(equipmentid) ON UPDATE CASCADE ON DELETE CASCADE;
 M   ALTER TABLE ONLY "Equipment".eqcurlmachine DROP CONSTRAINT equipcurlmachine;
    	   Equipment          postgres    false    224    2838    218            /           2606    24762    eqdumbells equipdumbells    FK CONSTRAINT     �   ALTER TABLE ONLY "Equipment".eqdumbells
    ADD CONSTRAINT equipdumbells FOREIGN KEY (equipmentid) REFERENCES "Equipment".equipment(equipmentid) ON UPDATE CASCADE ON DELETE CASCADE;
 G   ALTER TABLE ONLY "Equipment".eqdumbells DROP CONSTRAINT equipdumbells;
    	   Equipment          postgres    false    2838    225    218            ,           2606    24767     eqlattpulldown equiplattpulldown    FK CONSTRAINT     �   ALTER TABLE ONLY "Equipment".eqlattpulldown
    ADD CONSTRAINT equiplattpulldown FOREIGN KEY (equipmentid) REFERENCES "Equipment".equipment(equipmentid) ON UPDATE CASCADE ON DELETE CASCADE;
 O   ALTER TABLE ONLY "Equipment".eqlattpulldown DROP CONSTRAINT equiplattpulldown;
    	   Equipment          postgres    false    222    218    2838            0           2606    24772     eqlegextension equiplegextension    FK CONSTRAINT     �   ALTER TABLE ONLY "Equipment".eqlegextension
    ADD CONSTRAINT equiplegextension FOREIGN KEY (equipmentid) REFERENCES "Equipment".equipment(equipmentid) ON UPDATE CASCADE ON DELETE CASCADE;
 O   ALTER TABLE ONLY "Equipment".eqlegextension DROP CONSTRAINT equiplegextension;
    	   Equipment          postgres    false    218    226    2838            +           2606    24777    eqtreadmill equiptreadmill    FK CONSTRAINT     �   ALTER TABLE ONLY "Equipment".eqtreadmill
    ADD CONSTRAINT equiptreadmill FOREIGN KEY (equipmentid) REFERENCES "Equipment".equipment(equipmentid) ON UPDATE CASCADE ON DELETE CASCADE;
 I   ALTER TABLE ONLY "Equipment".eqtreadmill DROP CONSTRAINT equiptreadmill;
    	   Equipment          postgres    false    2838    218    221            �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �   �   x�-���0��d
O��
��,�����LfȽ����H��~���{��NP���d_�ZQk �l"�=
\�����F\% D���� XȀ�A6ݣ"�]��A����)���� 3)_)���A�D�I���np��9���L�      �   c   x�ʱ�0�ڞ�&H�a�o��N���Ha��$�{Cx��y�+$u��f%ae��ߺ����U�Ƃ$Ǉ����5p>��Պ���G����#      �   c   x�ʱ� F���	l��X��͏!��q��c���`Ҽ�{����Ӂ�f�f�P
�´D�2��ܜ��������i��%8G訋Y��Xk �$�      �   p   x�ʱ�0 �ڞB���@#�tQ|��/�2��t{��?�ӓl���Y:�O�q,h�^�a�(�߾���ع��.�%o|aa�E��
+У��)��:�w�-�      �   L   x�3�t.-�Q�ML���K����Q�N,�I,:�1��F��Ԝ̣�K2�R��2�R�3r�R�l,��4����� h��      �   c   x�3�t)�MJ��)�t���ˬJU(>�����<��T���"���L��ĢĴ#�RR���,QH<2��Ƣ�J��Č�����xvNb��W� ]')�      �   d   x��1
�0 ��}E^��'|�K�ABbiE�3��}��_�zp��7Ր��f6XQ8�g[U4X��D�9+EȭZ�P�U�'-Y�s��:���$�      �   u   x��1�  gx�_�9k�n}B'�*dj"R�g��l��B�;�r�{���B�Cw�\�#�u�ކ�<r9!@�Y�h����^�iGE�r���hH�jݓ�*�Mn���{�61$      �   a   x���)JML����QpN,J���L<2_�21���\���{�R�3�2u���R2�+��J�JR�l,J�S��?:�T!)1�WH�I-�������� K}"�      �      x�34�)�LN-(VpJ,�44����� M�      �      x�]��n�0E��W���`;�V�������ń�XI)?Cx��������/����GG�c������\�;<�@r��6F)�����.�%e�͊	��U�e���
I��>�om�Y�״pU2z9yu|�&0g
k{=�
�������PIH����s!&e�E��
*&R!�4dqy=f���r�{�.C��Iw�a�ޟ�s��Z!�H�}3a�b��c�ԗӟX����1t�퉭�n�	�)���m3c����w�      �   (   x���  ��R�8���&�C�M:���DoI�R��      �   �   x�M̽
�0��˫��!�D(E�ɥ�ņ�I#���|1u���Q�(�i�fnΚrx��[_����{��>]�~�Y�8dh����P�%68�9$l^�(�P�Cfk�H�u�*���~!��Y��B)��:e      �      x������� � �      �      x�3����� v �     