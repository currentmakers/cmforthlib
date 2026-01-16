\
\ @file exti.fs
\ @brief External interrupt/event       controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief IMR
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$007fffff constant EXTI_IMR_MR                                      \ Interrupt mask on line x


\
\ @brief EMR
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$007fffff constant EXTI_EMR_MR                                      \ Event mask on line x


\
\ @brief RTSR
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$007fffff constant EXTI_RTSR_TR                                     \ Rising edge trigger event configuration bit of line x


\
\ @brief FTSR
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$007fffff constant EXTI_FTSR_TR                                     \ Falling edge trigger event configuration bit of line x


\
\ @brief SWIER
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$007fffff constant EXTI_SWIER_SWIER                                 \ Software interrupt on line x


\
\ @brief PR
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$007fffff constant EXTI_PR_PR                                       \ Pending bit


\
\ @brief External interrupt/event controller
\
$40010400 constant EXTI_IMR       \ offset: 0x00 : IMR
$40010404 constant EXTI_EMR       \ offset: 0x04 : EMR
$40010408 constant EXTI_RTSR      \ offset: 0x08 : RTSR
$4001040c constant EXTI_FTSR      \ offset: 0x0C : FTSR
$40010410 constant EXTI_SWIER     \ offset: 0x10 : SWIER
$40010414 constant EXTI_PR        \ offset: 0x14 : PR

