\
\ @file comp.fs
\ @brief Comparator control and status register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Comparator control/status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP_C1CSR_EN                               \ EN
$00000070 constant COMP_COMP_C1CSR_INMSEL                           \ INMSEL
$00000100 constant COMP_COMP_C1CSR_INPSEL                           \ INPSEL
$00008000 constant COMP_COMP_C1CSR_POL                              \ POL
$00070000 constant COMP_COMP_C1CSR_HYST                             \ HYST
$00380000 constant COMP_COMP_C1CSR_BLANKSEL                         \ BLANKSEL
$00400000 constant COMP_COMP_C1CSR_BRGEN                            \ BRGEN
$00800000 constant COMP_COMP_C1CSR_SCALEN                           \ SCALEN
$40000000 constant COMP_COMP_C1CSR_VALUE                            \ VALUE
$80000000 constant COMP_COMP_C1CSR_LOCK                             \ LOCK


\
\ @brief Comparator control/status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP_C2CSR_EN                               \ EN
$00000070 constant COMP_COMP_C2CSR_INMSEL                           \ INMSEL
$00000100 constant COMP_COMP_C2CSR_INPSEL                           \ INPSEL
$00008000 constant COMP_COMP_C2CSR_POL                              \ POL
$00070000 constant COMP_COMP_C2CSR_HYST                             \ HYST
$00380000 constant COMP_COMP_C2CSR_BLANKSEL                         \ BLANKSEL
$00400000 constant COMP_COMP_C2CSR_BRGEN                            \ BRGEN
$00800000 constant COMP_COMP_C2CSR_SCALEN                           \ SCALEN
$40000000 constant COMP_COMP_C2CSR_VALUE                            \ VALUE
$80000000 constant COMP_COMP_C2CSR_LOCK                             \ LOCK


\
\ @brief Comparator control/status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP_C3CSR_EN                               \ EN
$00000070 constant COMP_COMP_C3CSR_INMSEL                           \ INMSEL
$00000100 constant COMP_COMP_C3CSR_INPSEL                           \ INPSEL
$00008000 constant COMP_COMP_C3CSR_POL                              \ POL
$00070000 constant COMP_COMP_C3CSR_HYST                             \ HYST
$00380000 constant COMP_COMP_C3CSR_BLANKSEL                         \ BLANKSEL
$00400000 constant COMP_COMP_C3CSR_BRGEN                            \ BRGEN
$00800000 constant COMP_COMP_C3CSR_SCALEN                           \ SCALEN
$40000000 constant COMP_COMP_C3CSR_VALUE                            \ VALUE
$80000000 constant COMP_COMP_C3CSR_LOCK                             \ LOCK


\
\ @brief Comparator control/status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP_C4CSR_EN                               \ EN
$00000070 constant COMP_COMP_C4CSR_INMSEL                           \ INMSEL
$00000100 constant COMP_COMP_C4CSR_INPSEL                           \ INPSEL
$00008000 constant COMP_COMP_C4CSR_POL                              \ POL
$00070000 constant COMP_COMP_C4CSR_HYST                             \ HYST
$00380000 constant COMP_COMP_C4CSR_BLANKSEL                         \ BLANKSEL
$00400000 constant COMP_COMP_C4CSR_BRGEN                            \ BRGEN
$00800000 constant COMP_COMP_C4CSR_SCALEN                           \ SCALEN
$40000000 constant COMP_COMP_C4CSR_VALUE                            \ VALUE
$80000000 constant COMP_COMP_C4CSR_LOCK                             \ LOCK


\
\ @brief Comparator control/status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP_C5CSR_EN                               \ EN
$00000070 constant COMP_COMP_C5CSR_INMSEL                           \ INMSEL
$00000100 constant COMP_COMP_C5CSR_INPSEL                           \ INPSEL
$00008000 constant COMP_COMP_C5CSR_POL                              \ POL
$00070000 constant COMP_COMP_C5CSR_HYST                             \ HYST
$00380000 constant COMP_COMP_C5CSR_BLANKSEL                         \ BLANKSEL
$00400000 constant COMP_COMP_C5CSR_BRGEN                            \ BRGEN
$00800000 constant COMP_COMP_C5CSR_SCALEN                           \ SCALEN
$40000000 constant COMP_COMP_C5CSR_VALUE                            \ VALUE
$80000000 constant COMP_COMP_C5CSR_LOCK                             \ LOCK


\
\ @brief Comparator control/status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP_C6CSR_EN                               \ EN
$00000070 constant COMP_COMP_C6CSR_INMSEL                           \ INMSEL
$00000100 constant COMP_COMP_C6CSR_INPSEL                           \ INPSEL
$00008000 constant COMP_COMP_C6CSR_POL                              \ POL
$00070000 constant COMP_COMP_C6CSR_HYST                             \ HYST
$00380000 constant COMP_COMP_C6CSR_BLANKSEL                         \ BLANKSEL
$00400000 constant COMP_COMP_C6CSR_BRGEN                            \ BRGEN
$00800000 constant COMP_COMP_C6CSR_SCALEN                           \ SCALEN
$40000000 constant COMP_COMP_C6CSR_VALUE                            \ VALUE
$80000000 constant COMP_COMP_C6CSR_LOCK                             \ LOCK


\
\ @brief Comparator control/status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP_C7CSR_EN                               \ EN
$00000070 constant COMP_COMP_C7CSR_INMSEL                           \ INMSEL
$00000100 constant COMP_COMP_C7CSR_INPSEL                           \ INPSEL
$00008000 constant COMP_COMP_C7CSR_POL                              \ POL
$00070000 constant COMP_COMP_C7CSR_HYST                             \ HYST
$00380000 constant COMP_COMP_C7CSR_BLANKSEL                         \ BLANKSEL
$00400000 constant COMP_COMP_C7CSR_BRGEN                            \ BRGEN
$00800000 constant COMP_COMP_C7CSR_SCALEN                           \ SCALEN
$40000000 constant COMP_COMP_C7CSR_VALUE                            \ VALUE
$80000000 constant COMP_COMP_C7CSR_LOCK                             \ LOCK


\
\ @brief Comparator control and status register
\
$40010200 constant COMP_COMP_C1CSR  \ offset: 0x00 : Comparator control/status register
$40010204 constant COMP_COMP_C2CSR  \ offset: 0x04 : Comparator control/status register
$40010208 constant COMP_COMP_C3CSR  \ offset: 0x08 : Comparator control/status register
$4001020c constant COMP_COMP_C4CSR  \ offset: 0x0C : Comparator control/status register
$40010210 constant COMP_COMP_C5CSR  \ offset: 0x10 : Comparator control/status register
$40010214 constant COMP_COMP_C6CSR  \ offset: 0x14 : Comparator control/status register
$40010218 constant COMP_COMP_C7CSR  \ offset: 0x18 : Comparator control/status register

