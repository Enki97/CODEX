{ DATABASE sigen  delimiter | }

grant dba to "informix";











{ TABLE "informix".usuario row size = 862 number of columns = 17 index size = 0 }
{ unload file name = usuar00100.unl number of rows = 0 }

create table "informix".usuario 
  (
    documento integer not null ,
    primernombre char(30) not null ,
    segundonombre char(30),
    primerapellido char(30) not null ,
    segundoapellido char(30) not null ,
    fechanac date not null ,
    email char(140) not null ,
    foto char(190),
    dir_calle char(50) not null ,
    dir_numero integer not null ,
    dir_bis integer not null ,
    dir_apartamento integer,
    nacionalidad char(140) not null ,
    rol char(40) not null ,
    sexo char(30) not null ,
    inactivo integer not null ,
    contrasenia char(128) not null 
  );

revoke all on "informix".usuario from "public" as "informix";

{ TABLE "informix".usuario_telefono row size = 8 number of columns = 2 index size 
              = 13 }
{ unload file name = usuar00101.unl number of rows = 0 }

create table "informix".usuario_telefono 
  (
    documento integer not null ,
    telefono integer not null ,
    primary key (documento,telefono)  constraint "informix".usuario_telefono_pk
  );

revoke all on "informix".usuario_telefono from "public" as "informix";

{ TABLE "informix".deportista row size = 61 number of columns = 8 index size = 13 
              }
{ unload file name = depor00102.unl number of rows = 0 }

create table "informix".deportista 
  (
    documento integer not null ,
    nro_socio integer not null ,
    altura integer not null ,
    peso integer not null ,
    venfichamedica date not null ,
    criterio char(11) not null ,
    imc decimal(16) not null ,
    somatotipo char(20) not null ,
    primary key (documento,nro_socio)  constraint "informix".deportista_pk
  );

revoke all on "informix".deportista from "public" as "informix";

{ TABLE "informix".alergias row size = 144 number of columns = 2 index size = 149 
              }
{ unload file name = alerg00103.unl number of rows = 0 }

create table "informix".alergias 
  (
    documento integer not null ,
    alergias char(140) not null ,
    primary key (documento,alergias)  constraint "informix".alergias_pk
  );

revoke all on "informix".alergias from "public" as "informix";

{ TABLE "informix".medicamentos row size = 144 number of columns = 2 index size = 
              149 }
{ unload file name = medic00104.unl number of rows = 0 }

create table "informix".medicamentos 
  (
    documento integer not null ,
    medicamentos char(140) not null ,
    primary key (documento,medicamentos)  constraint "informix".medicamentos_pk
  );

revoke all on "informix".medicamentos from "public" as "informix";

{ TABLE "informix".vacunas row size = 144 number of columns = 2 index size = 149 
              }
{ unload file name = vacun00105.unl number of rows = 0 }

create table "informix".vacunas 
  (
    documento integer not null ,
    vacunas char(140) not null ,
    primary key (documento,vacunas)  constraint "informix".vacunas_pk
  );

revoke all on "informix".vacunas from "public" as "informix";

{ TABLE "informix".operaciones row size = 144 number of columns = 2 index size = 
              149 }
{ unload file name = opera00106.unl number of rows = 0 }

create table "informix".operaciones 
  (
    documento integer not null ,
    operaciones char(140) not null ,
    primary key (documento,operaciones)  constraint "informix".operaciones_pk
  );

revoke all on "informix".operaciones from "public" as "informix";

{ TABLE "informix".seleccionador row size = 8 number of columns = 2 index size = 
              13 }
{ unload file name = selec00107.unl number of rows = 0 }

create table "informix".seleccionador 
  (
    documento integer not null ,
    acreditacion_seleccionador integer not null ,
    primary key (documento,acreditacion_seleccionador)  constraint "informix".seleccionador_pk
  );

revoke all on "informix".seleccionador from "public" as "informix";

{ TABLE "informix".entrenador row size = 8 number of columns = 2 index size = 13 
              }
{ unload file name = entre00108.unl number of rows = 0 }

create table "informix".entrenador 
  (
    documento integer not null ,
    acreditacion_entrenador integer not null ,
    primary key (documento,acreditacion_entrenador)  constraint "informix".entrenador_pk
  );

revoke all on "informix".entrenador from "public" as "informix";

{ TABLE "informix".avanzado row size = 8 number of columns = 2 index size = 13 }
{ unload file name = avanz00109.unl number of rows = 0 }

create table "informix".avanzado 
  (
    documento integer not null ,
    nro_funcionario integer not null ,
    primary key (documento,nro_funcionario)  constraint "informix".avanzado_pk
  );

revoke all on "informix".avanzado from "public" as "informix";

{ TABLE "informix".instituto row size = 356 number of columns = 7 index size = 0 
              }
{ unload file name = insti00110.unl number of rows = 0 }

create table "informix".instituto 
  (
    rut bigint not null ,
    nombre char(30) not null ,
    dir_calle char(50) not null ,
    dir_num integer not null ,
    dir_bis integer not null ,
    email char(140) not null ,
    sitio_web char(120) not null 
  );

revoke all on "informix".instituto from "public" as "informix";

{ TABLE "informix".pertenece row size = 20 number of columns = 4 index size = 0 }
{ unload file name = perte00112.unl number of rows = 0 }

create table "informix".pertenece 
  (
    documento integer not null ,
    rut bigint not null ,
    fecha_inicio date not null ,
    fecha_fin date
  );

revoke all on "informix".pertenece from "public" as "informix";

{ TABLE "informix".actividad row size = 784 number of columns = 4 index size = 9 
              }
{ unload file name = activ00113.unl number of rows = 0 }

create table "informix".actividad 
  (
    id_actividad integer not null ,
    nombre char(140) not null ,
    descripcion char(500) not null ,
    imagen char(140) not null ,
    primary key (id_actividad)  constraint "informix".actividad_pk
  );

revoke all on "informix".actividad from "public" as "informix";

{ TABLE "informix".realizan row size = 46 number of columns = 3 index size = 9 }
{ unload file name = reali00114.unl number of rows = 0 }

create table "informix".realizan 
  (
    documento integer not null ,
    id_actividad integer not null ,
    posicion char(38) not null ,
    primary key (documento)  constraint "informix".realizan_pk
  );

revoke all on "informix".realizan from "public" as "informix";

{ TABLE "informix".evolucion row size = 44 number of columns = 11 index size = 13 
              }
{ unload file name = evolu00115.unl number of rows = 0 }

create table "informix".evolucion 
  (
    documento_deportista integer not null ,
    documento_entrenador integer not null ,
    fecha date not null ,
    cumplimiento integer not null ,
    resistenciaanaerobica integer not null ,
    resistenciamuscular integer not null ,
    fuerzamuscular integer not null ,
    flexibilidad integer not null ,
    resistenciamonotonia integer not null ,
    recilencia integer not null ,
    promedio integer not null ,
    primary key (documento_deportista,fecha)  constraint "informix".evolucion_pk
  );

revoke all on "informix".evolucion from "public" as "informix";

{ TABLE "informix".equipos row size = 32 number of columns = 4 index size = 18 }
{ unload file name = equip00116.unl number of rows = 0 }

create table "informix".equipos 
  (
    id_equipo integer not null ,
    categoria char(20) not null ,
    esseleccion integer not null ,
    actividad integer not null ,
    primary key (id_equipo)  constraint "informix".equipos_pk
  );

revoke all on "informix".equipos from "public" as "informix";

{ TABLE "informix".eq_re row size = 8 number of columns = 2 index size = 9 }
{ unload file name = eq_re00117.unl number of rows = 0 }

create table "informix".eq_re 
  (
    documento integer not null ,
    id_equipo integer not null ,
    primary key (documento)  constraint "informix".eq_re_pk
  );

revoke all on "informix".eq_re from "public" as "informix";

{ TABLE "informix".sectores row size = 52 number of columns = 3 index size = 17 }
{ unload file name = secto00118.unl number of rows = 0 }

create table "informix".sectores 
  (
    rut bigint not null ,
    nro_sector integer not null ,
    nombre char(40) not null ,
    primary key (rut,nro_sector)  constraint "informix".sectores_pk
  );

revoke all on "informix".sectores from "public" as "informix";

{ TABLE "informix".serealizanas row size = 16 number of columns = 3 index size = 
              21 }
{ unload file name = serea00119.unl number of rows = 0 }

create table "informix".serealizanas 
  (
    rut bigint not null ,
    nro_sector integer not null ,
    id_actividad integer not null ,
    primary key (rut,nro_sector,id_actividad)  constraint "informix".serealizanas
  );

revoke all on "informix".serealizanas from "public" as "informix";

{ TABLE "informix".gruposmusculares row size = 824 number of columns = 5 index size 
              = 9 }
{ unload file name = grupo00120.unl number of rows = 0 }

create table "informix".gruposmusculares 
  (
    id_grupos integer not null ,
    nombre char(40) not null ,
    descripcion char(500) not null ,
    imagen char(140) not null ,
    tipo char(140) not null ,
    primary key (id_grupos)  constraint "informix".gruposmusculares_pk
  );

revoke all on "informix".gruposmusculares from "public" as "informix";

{ TABLE "informix".combos row size = 544 number of columns = 3 index size = 9 }
{ unload file name = combo00121.unl number of rows = 0 }

create table "informix".combos 
  (
    id_combo integer not null ,
    nombre char(40) not null ,
    descripcion char(500) not null ,
    primary key (id_combo)  constraint "informix".combo_pk
  );

revoke all on "informix".combos from "public" as "informix";

{ TABLE "informix".cumple row size = 8 number of columns = 2 index size = 13 }
{ unload file name = cumpl00122.unl number of rows = 0 }

create table "informix".cumple 
  (
    id_planes integer not null ,
    documento integer not null ,
    primary key (id_planes,documento)  constraint "informix".cumple_pk
  );

revoke all on "informix".cumple from "public" as "informix";

{ TABLE "informix".planesentrenamiento row size = 592 number of columns = 6 index 
              size = 9 }
{ unload file name = plane00123.unl number of rows = 0 }

create table "informix".planesentrenamiento 
  (
    id_planes integer not null ,
    nombre char(40) not null ,
    descripcion char(500) not null ,
    fase char(40) not null ,
    fechadesde date not null ,
    fechahasta date not null ,
    primary key (id_planes)  constraint "informix".planesentrenamiento_pk
  );

revoke all on "informix".planesentrenamiento from "public" as "informix";

{ TABLE "informix".asigna row size = 8 number of columns = 2 index size = 13 }
{ unload file name = asign00124.unl number of rows = 0 }

create table "informix".asigna 
  (
    documento integer not null ,
    id_planes integer not null ,
    primary key (documento,id_planes)  constraint "informix".asigna_pk
  );

revoke all on "informix".asigna from "public" as "informix";

{ TABLE "informix".ejercicio row size = 834 number of columns = 5 index size = 9 
              }
{ unload file name = ejerc00125.unl number of rows = 0 }

create table "informix".ejercicio 
  (
    id_ejercicio integer not null ,
    nombre char(50) not null ,
    descripcion char(500) not null ,
    imagen char(140) not null ,
    video char(140) not null ,
    primary key (id_ejercicio)  constraint "informix".ejercicios_pk
  );

revoke all on "informix".ejercicio from "public" as "informix";

{ TABLE "informix".agrupan row size = 8 number of columns = 2 index size = 18 }
{ unload file name = agrup00126.unl number of rows = 0 }

create table "informix".agrupan 
  (
    id_combos integer not null ,
    id_ejercicios integer not null 
  );

revoke all on "informix".agrupan from "public" as "informix";

{ TABLE "informix".entrena row size = 8 number of columns = 2 index size = 31 }
{ unload file name = entre00127.unl number of rows = 0 }

create table "informix".entrena 
  (
    id_ejercicio integer not null ,
    id_grupos integer not null ,
    primary key (id_ejercicio,id_grupos)  constraint "informix".entrena_pk
  );

revoke all on "informix".entrena from "public" as "informix";

{ TABLE "informix".pla_com row size = 56 number of columns = 8 index size = 31 }
{ unload file name = pla_c00128.unl number of rows = 0 }

create table "informix".pla_com 
  (
    id_planes integer not null ,
    id_combo integer not null ,
    sesion char(12) not null ,
    cantidad integer not null ,
    kcal_quemadas integer not null ,
    carga integer not null ,
    repeticiones integer not null ,
    modo char(20) not null ,
    primary key (id_combo,id_planes)  constraint "informix".pla_com_pk
  );

revoke all on "informix".pla_com from "public" as "informix";

{ TABLE "informix".pla_ej row size = 56 number of columns = 8 index size = 31 }
{ unload file name = pla_e00129.unl number of rows = 0 }

create table "informix".pla_ej 
  (
    id_planes integer not null ,
    id_ejercicio integer not null ,
    sesion char(12) not null ,
    cantidad integer not null ,
    kcal_quemadas integer not null ,
    carga integer not null ,
    repeticiones integer not null ,
    modo char(20) not null ,
    primary key (id_planes,id_ejercicio)  constraint "informix".pla_ej_pk
  );

revoke all on "informix".pla_ej from "public" as "informix";

{ TABLE "informix".telefono_instituto row size = 12 number of columns = 2 index size 
              = 0 }
{ unload file name = telef00130.unl number of rows = 0 }

create table "informix".telefono_instituto 
  (
    rut bigint not null ,
    telefono integer not null 
  );

revoke all on "informix".telefono_instituto from "public" as "informix";




grant select on "informix".entrena to "public" as "informix";
grant update on "informix".entrena to "public" as "informix";
grant insert on "informix".entrena to "public" as "informix";
grant delete on "informix".entrena to "public" as "informix";
grant index on "informix".entrena to "public" as "informix";
grant select on "informix".pla_com to "public" as "informix";
grant update on "informix".pla_com to "public" as "informix";
grant insert on "informix".pla_com to "public" as "informix";
grant delete on "informix".pla_com to "public" as "informix";
grant index on "informix".pla_com to "public" as "informix";
grant select on "informix".pla_ej to "public" as "informix";
grant update on "informix".pla_ej to "public" as "informix";
grant insert on "informix".pla_ej to "public" as "informix";
grant delete on "informix".pla_ej to "public" as "informix";
grant index on "informix".pla_ej to "public" as "informix";















revoke usage on language SPL from public ;

grant usage on language SPL to public ;








alter table "informix".agrupan add constraint (foreign key (id_combos) 
    references "informix".combos  on delete cascade constraint 
    "informix".agrupan_fk2);
alter table "informix".agrupan add constraint (foreign key (id_ejercicios) 
    references "informix".ejercicio  on delete cascade constraint 
    "informix".agrupan_fk3);
alter table "informix".entrena add constraint (foreign key (id_ejercicio) 
    references "informix".ejercicio  on delete cascade constraint 
    "informix".entrena_fk1);
alter table "informix".entrena add constraint (foreign key (id_grupos) 
    references "informix".gruposmusculares  on delete cascade 
    constraint "informix".entrena_fk2);
alter table "informix".pla_com add constraint (foreign key (id_combo) 
    references "informix".combos  on delete cascade constraint 
    "informix".pla_com_fk1);
alter table "informix".pla_com add constraint (foreign key (id_planes) 
    references "informix".planesentrenamiento  on delete cascade 
    constraint "informix".pla_com_fk2);
alter table "informix".pla_ej add constraint (foreign key (id_planes) 
    references "informix".planesentrenamiento  on delete cascade 
    constraint "informix".pla_ej_fk1);
alter table "informix".pla_ej add constraint (foreign key (id_ejercicio) 
    references "informix".ejercicio  on delete cascade constraint 
    "informix".pla_ej_fk2);
alter table "informix".equipos add constraint (foreign key (actividad) 
    references "informix".actividad  constraint "informix".equipos_fk);
    







 


