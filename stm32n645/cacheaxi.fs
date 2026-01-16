\
\ @file cacheaxi.fs
\ @brief AXI cache
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CACHEAXI control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant CACHEAXI_CACHEAXI_CR1_EN                         \ enable
$00000002 constant CACHEAXI_CACHEAXI_CR1_CACHEINV                   \ full cache invalidation
$00010000 constant CACHEAXI_CACHEAXI_CR1_RHITMEN                    \ read-hit monitor enable
$00020000 constant CACHEAXI_CACHEAXI_CR1_RMISSMEN                   \ read-miss monitor enable
$00040000 constant CACHEAXI_CACHEAXI_CR1_RHITMRST                   \ read-hit monitor reset
$00080000 constant CACHEAXI_CACHEAXI_CR1_RMISSMRST                  \ read-miss monitor reset
$00100000 constant CACHEAXI_CACHEAXI_CR1_WHITMEN                    \ write-hit monitor enable
$00200000 constant CACHEAXI_CACHEAXI_CR1_WMISSMEN                   \ write-miss monitor enable
$00400000 constant CACHEAXI_CACHEAXI_CR1_WHITMRST                   \ write-hit monitor reset
$00800000 constant CACHEAXI_CACHEAXI_CR1_WMISSMRST                  \ write-miss monitor reset
$01000000 constant CACHEAXI_CACHEAXI_CR1_RAMMEN                     \ read-allocate miss monitor enable
$02000000 constant CACHEAXI_CACHEAXI_CR1_WAMMEN                     \ write-allocate miss monitor enable
$04000000 constant CACHEAXI_CACHEAXI_CR1_RAMMRST                    \ read-allocate miss monitor reset
$08000000 constant CACHEAXI_CACHEAXI_CR1_WAMMRST                    \ write-allocate miss monitor reset
$10000000 constant CACHEAXI_CACHEAXI_CR1_WTMEN                      \ write-through monitor enable
$20000000 constant CACHEAXI_CACHEAXI_CR1_EVIMEN                     \ eviction monitor enable
$40000000 constant CACHEAXI_CACHEAXI_CR1_WTMRST                     \ write-through monitor reset
$80000000 constant CACHEAXI_CACHEAXI_CR1_EVIMRST                    \ eviction monitor reset


\
\ @brief CACHEAXI status register
\ Address offset: 0x04
\ Reset value: 0x00000001
\

$00000001 constant CACHEAXI_CACHEAXI_SR_BUSYF                       \ full invalidate busy flag
$00000002 constant CACHEAXI_CACHEAXI_SR_BSYENDF                     \ full invalidate busy end flag
$00000004 constant CACHEAXI_CACHEAXI_SR_ERRF                        \ cache error flag
$00000008 constant CACHEAXI_CACHEAXI_SR_BUSYCMDF                    \ command busy flag
$00000010 constant CACHEAXI_CACHEAXI_SR_CMDENDF                     \ command end flag


\
\ @brief CACHEAXI interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant CACHEAXI_CACHEAXI_IER_BSYENDIE                   \ interrupt enable on busy end
$00000004 constant CACHEAXI_CACHEAXI_IER_ERRIE                      \ interrupt enable on cache error
$00000010 constant CACHEAXI_CACHEAXI_IER_CMDENDIE                   \ interrupt enable on command end


\
\ @brief CACHEAXI flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant CACHEAXI_CACHEAXI_FCR_CBSYENDF                   \ clear full invalidate busy end flag
$00000004 constant CACHEAXI_CACHEAXI_FCR_CERRF                      \ clear cache error flag
$00000010 constant CACHEAXI_CACHEAXI_FCR_CCMDENDF                   \ clear command end flag


\
\ @brief CACHEAXI read-hit monitor register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant CACHEAXI_CACHEAXI_RHMONR_RHITMON                 \ cache read-hit monitor counter


\
\ @brief CACHEAXI read-miss monitor register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant CACHEAXI_CACHEAXI_RMMONR_RMISSMON                \ cache read-miss monitor counter


\
\ @brief CACHEAXI read-allocate miss monitor register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant CACHEAXI_CACHEAXI_RAMMONR_RAMMON                 \ cache read-allocate miss monitor counter


\
\ @brief CACHEAXI eviction monitor register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant CACHEAXI_CACHEAXI_EVIMONR_EVIMON                 \ cache eviction monitor counter


\
\ @brief CACHEAXI write-hit monitor register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant CACHEAXI_CACHEAXI_WHMONR_WHITMON                 \ cache write-hit monitor counter


\
\ @brief CACHEAXI write-miss monitor register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant CACHEAXI_CACHEAXI_WMMONR_WMISSMON                \ cache write-miss monitor counter


\
\ @brief CACHEAXI write-allocate miss monitor register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant CACHEAXI_CACHEAXI_WAMMONR_WAMMON                 \ cache write-allocate miss monitor counter


\
\ @brief CACHEAXI write-through monitor register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant CACHEAXI_CACHEAXI_WTMONR_WTMON                   \ cache write-through monitor counter


\
\ @brief CACHEAXI control register 2
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant CACHEAXI_CACHEAXI_CR2_STARTCMD                   \ starts maintenance range command (maintenance operation defined in CACHECMD).
$00000006 constant CACHEAXI_CACHEAXI_CR2_CACHECMD                   \ cache command maintenance operation (clean or clean-and-invalidate an address range)


\
\ @brief CACHEAXI command range start address register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$ffffffc0 constant CACHEAXI_CACHEAXI_CMDRSADDRR_CMDSTARTADDR        \ start address of range to which the cache maintenance command specified in CACHEAXI_CR2.CACHECMD field applies


\
\ @brief CACHEAXI command range end address register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$ffffffc0 constant CACHEAXI_CACHEAXI_CMDREADDRR_CMDENDADDR          \ end address of range to which the cache maintenance command specified in CACHEAXI_CR2.CACHECMD field applies


\
\ @brief AXI cache
\
$480dfc00 constant CACHEAXI_CACHEAXI_CR1  \ offset: 0x00 : CACHEAXI control register 1
$480dfc04 constant CACHEAXI_CACHEAXI_SR  \ offset: 0x04 : CACHEAXI status register
$480dfc08 constant CACHEAXI_CACHEAXI_IER  \ offset: 0x08 : CACHEAXI interrupt enable register
$480dfc0c constant CACHEAXI_CACHEAXI_FCR  \ offset: 0x0C : CACHEAXI flag clear register
$480dfc10 constant CACHEAXI_CACHEAXI_RHMONR  \ offset: 0x10 : CACHEAXI read-hit monitor register
$480dfc14 constant CACHEAXI_CACHEAXI_RMMONR  \ offset: 0x14 : CACHEAXI read-miss monitor register
$480dfc18 constant CACHEAXI_CACHEAXI_RAMMONR  \ offset: 0x18 : CACHEAXI read-allocate miss monitor register
$480dfc1c constant CACHEAXI_CACHEAXI_EVIMONR  \ offset: 0x1C : CACHEAXI eviction monitor register
$480dfc20 constant CACHEAXI_CACHEAXI_WHMONR  \ offset: 0x20 : CACHEAXI write-hit monitor register
$480dfc24 constant CACHEAXI_CACHEAXI_WMMONR  \ offset: 0x24 : CACHEAXI write-miss monitor register
$480dfc28 constant CACHEAXI_CACHEAXI_WAMMONR  \ offset: 0x28 : CACHEAXI write-allocate miss monitor register
$480dfc2c constant CACHEAXI_CACHEAXI_WTMONR  \ offset: 0x2C : CACHEAXI write-through monitor register
$480dfd00 constant CACHEAXI_CACHEAXI_CR2  \ offset: 0x100 : CACHEAXI control register 2
$480dfd04 constant CACHEAXI_CACHEAXI_CMDRSADDRR  \ offset: 0x104 : CACHEAXI command range start address register
$480dfd08 constant CACHEAXI_CACHEAXI_CMDREADDRR  \ offset: 0x108 : CACHEAXI command range end address register

