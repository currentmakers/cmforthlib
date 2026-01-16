\
\ @file dcache1.fs
\ @brief DCACHE1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DCACHE control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DCACHE1_DCACHE_CR_EN                             \ EN
$00000002 constant DCACHE1_DCACHE_CR_CACHEINV                       \ CACHEINV
$00000700 constant DCACHE1_DCACHE_CR_CACHECMD                       \ CACHECMD
$00000800 constant DCACHE1_DCACHE_CR_STARTCMD                       \ STARTCMD
$00010000 constant DCACHE1_DCACHE_CR_RHITMEN                        \ RHITMEN
$00020000 constant DCACHE1_DCACHE_CR_RMISSMEN                       \ RMISSMEN
$00040000 constant DCACHE1_DCACHE_CR_RHITMRST                       \ RHITMRST
$00080000 constant DCACHE1_DCACHE_CR_RMISSMRST                      \ RMISSMRST
$00100000 constant DCACHE1_DCACHE_CR_WHITMEN                        \ WHITMEN
$00200000 constant DCACHE1_DCACHE_CR_WMISSMEN                       \ WMISSMEN
$00400000 constant DCACHE1_DCACHE_CR_WHITMRST                       \ WHITMRST
$00800000 constant DCACHE1_DCACHE_CR_WMISSMRST                      \ WMISSMRST
$80000000 constant DCACHE1_DCACHE_CR_HBURST                         \ HBURST


\
\ @brief DCACHE status register
\ Address offset: 0x04
\ Reset value: 0x00000001
\

$00000001 constant DCACHE1_DCACHE_SR_BUSYF                          \ BUSYF
$00000002 constant DCACHE1_DCACHE_SR_BSYENDF                        \ BSYENDF
$00000004 constant DCACHE1_DCACHE_SR_ERRF                           \ ERRF
$00000008 constant DCACHE1_DCACHE_SR_BUSYCMDF                       \ BUSYCMDF
$00000010 constant DCACHE1_DCACHE_SR_CMDENDF                        \ CMDENDF


\
\ @brief DCACHE interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant DCACHE1_DCACHE_IER_BSYENDIE                      \ BSYENDIE
$00000004 constant DCACHE1_DCACHE_IER_ERRIE                         \ ERRIE
$00000010 constant DCACHE1_DCACHE_IER_CMDENDIE                      \ CMDENDIE


\
\ @brief DCACHE flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant DCACHE1_DCACHE_FCR_CBSYENDF                      \ CBSYENDF
$00000004 constant DCACHE1_DCACHE_FCR_CERRF                         \ CERRF
$00000010 constant DCACHE1_DCACHE_FCR_CCMDENDF                      \ CCMDENDF


\
\ @brief DCACHE read-hit monitor register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DCACHE1_DCACHE_RHMONR_RHITMON                    \ RHITMON


\
\ @brief DCACHE read-miss monitor register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant DCACHE1_DCACHE_RMMONR_MRISSMON                   \ RMISSMON


\
\ @brief write-hit monitor register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant DCACHE1_DCACHE_WHMONR_WHITMON                    \ WHITMON


\
\ @brief write-miss monitor register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant DCACHE1_DCACHE_WMMONR_WMISSMON                   \ WMISSMON


\
\ @brief command range start address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$fffffff0 constant DCACHE1_DCACHE_CMDRSADDRR_CMDSTARTADDR           \ CMDSTARTADDR


\
\ @brief command range start address register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$fffffff0 constant DCACHE1_DCACHE_CMDREADDRR_CMDENDADDR             \ CMDENDADDR


\
\ @brief DCACHE1
\
$40031400 constant DCACHE1_DCACHE_CR  \ offset: 0x00 : DCACHE control register
$40031404 constant DCACHE1_DCACHE_SR  \ offset: 0x04 : DCACHE status register
$40031408 constant DCACHE1_DCACHE_IER  \ offset: 0x08 : DCACHE interrupt enable register
$4003140c constant DCACHE1_DCACHE_FCR  \ offset: 0x0C : DCACHE flag clear register
$40031410 constant DCACHE1_DCACHE_RHMONR  \ offset: 0x10 : DCACHE read-hit monitor register
$40031414 constant DCACHE1_DCACHE_RMMONR  \ offset: 0x14 : DCACHE read-miss monitor register
$40031420 constant DCACHE1_DCACHE_WHMONR  \ offset: 0x20 : write-hit monitor register
$40031424 constant DCACHE1_DCACHE_WMMONR  \ offset: 0x24 : write-miss monitor register
$40031428 constant DCACHE1_DCACHE_CMDRSADDRR  \ offset: 0x28 : command range start address register
$4003142c constant DCACHE1_DCACHE_CMDREADDRR  \ offset: 0x2C : command range start address register

